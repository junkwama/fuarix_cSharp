using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Bilesenler;

namespace WindowsFormsApp2
{
    public partial class BiletSatinAlma : Form
    {

        public static int etkinlikIdvalue;
        public BiletSatinAlma(int etkinlikIdparametre)
        {
            InitializeComponent();
            etkinlikIdvalue = etkinlikIdparametre;
            etkinlik_Id.Text = etkinlikIdparametre.ToString();

            koltukAl();
        }
        

        void koltukAl()
        {
            
            DataTable koltuklarDT = Sorgular.oku(
                "SELECT koltuk_numarasi FROM koltuklar WHERE salon_id = (SELECT salon_id FROM etkinlikler WHERE id= " + etkinlikIdvalue + ")"
            );

            int koltukSayisi = koltuklarDT.Rows.Count;


            Koltuk koltuk;

            for (int j = 0; j < koltukSayisi; j++)
            {
                koltuk = new Koltuk(this.koltuk_id_label);
                koltuk.Height = 30;
                koltuk.Width = 70;

                if(j % 10 == 0)
                    koltuk.Top =  (((j / 10)) * 45) + 30;
                else
                    koltuk.Top = (j % 10 > 0) ? (int)Math.Ceiling(Convert.ToDouble(j / 10) * 45) + 30 : (((j / 10) - 1) * 45) + 30 ;
                
                if (j % 10 !=  0)
                    koltuk.Left = (j % 10 > 0 ) ? (int)Math.Ceiling( Convert.ToDouble(j % 10) * 80 ) : 10 * 80;
                else
                    koltuk.Left = 2;

                string koltuk_numarasi = koltuklarDT.Rows[j]["koltuk_numarasi"].ToString();
                koltuk.koltukID = koltuk_numarasi;

                DataTable koltukChekSorguDT = Sorgular.oku("SELECT * FROM biletler WHERE etkinlik_id=" + etkinlikIdvalue + " AND koltuk_numarasi='" + koltuk_numarasi + "'");
                bool koltukSecildi = koltukChekSorguDT.Rows.Count > 0;

                if (koltukSecildi)
                {
                    koltuk.Enabled = false;
                    koltuk.bg = Color.LightGray;
                }

                KoltukPaneli.Controls.Add(koltuk);
                
            }
        }



        private void BiletSatinAlma_Load(object sender, EventArgs e)
        {
            
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            string SecilenKoltukNumarasi = koltuk_id_label.Text.Trim();
            int uyeId = 0;

            try
            {
                uyeId = Convert.ToInt32(uye_ID.Text.Trim());
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }


            if  ( SecilenKoltukNumarasi == "Bir koltuk seçin" ) //Eğer kullanıcı koltuk seçmediyse...
            {
                MessageBox.Show("Bir koltuk şeçmeniz lazım");
            }else if (uyeId == 0) // Gersiz şeyler girdiyse
            {
                MessageBox.Show("Geçersiz Üye Id. Tekrar girin");
            }
            else
            {
                DataTable CheckUye = Sorgular.oku("SELECT id FROM uyeler WHERE id=" + uyeId);

                //Boyle bir uye yoksa
                if (CheckUye.Rows.Count < 1)
                {
                    MessageBox.Show("Üye-" + uyeId + " numaralı üye sistemde kayıtlı değil. Önce sisteme kaydını yapın.");
                }//varsa

                else if (Sorgular.oku("SELECT id FROM biletler WHERE etkinlik_id=" + etkinlikIdvalue + " AND uye_id=" + uyeId).Rows.Count > 0 )
                {
                    MessageBox.Show("Bir üye için sadece bir sandalye ayrılabilir.");
                }

                else
                {
                    string biletInsert = "INSERT INTO biletler(etkinlik_id, uye_id, koltuk_numarasi) ";
                    string biletValues = "VALUES (" + etkinlikIdvalue + " , " + uyeId + ", '" + SecilenKoltukNumarasi + "');";
                    string biletSorgu = biletInsert + biletValues;
                    try
                    {
                        Sorgular.ekle_guncele_sil(biletSorgu);
                        MessageBox.Show("Üye-" + uyeId + " için yer ayrılma işlemi başarili bir şekilde tamamlanmiştir.");
                        KoltukPaneli.Controls.Clear();
                        koltukAl();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Oluştu : " + ex.Message);
                    }
                }
            }
        
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
