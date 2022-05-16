using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace WindowsFormsApp2
{
    public partial class EtkinlikDetaylariForm : Form
    {
        private int etkId;
        private DataTable etkinkik;
        private DataTable etkinkikKonusmacilari;
        private DataTable etkinkikCanliBaglantilari;
        private DataTable etkinkikBilgiAlanlari;
        private DataTable etkinkikbiletleri;
        private string det;


        //Stact overflow rouded border oluşturmak için---------------//
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );//-----------------------------------------------//


        public EtkinlikDetaylariForm(int etkId)
        {
            this.etkId = etkId;
            etkVeriYukle();
            InitializeComponent();
        }

        private void EtkinlikDetaylariForm_Load(object sender, EventArgs e)
        {
            this.detayLab.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.detayLab.Width, this.detayLab.Height, 15, 15));
            this.girisLab.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.girisLab.Width, this.girisLab.Height, 15, 15));


            DataRow etk_temp = etkinkik.Rows[0];

            //this.etkBg.ImageLocation = etk_temp["arka_plan_linki"].ToString();
            this.konuLab.Text = etk_temp["baslik"].ToString();
            this.detayLab.Text += det;
            //Bilgi Alanlari
            this.detayLab.Text += "Katagori :\n";
            int a = etkinkikBilgiAlanlari.Rows.Count;
            for (int i = 0; i < a; i++)
            {
                this.detayLab.Text += "#" + etkinkikBilgiAlanlari.Rows[i]["bilgiAlani"] + " - ";
            }

            this.etkBanerDetayLab.Text = etk_temp["etkinlik_turu"].ToString();
            this.etkBanerDetayLab.Text += "\n" + etk_temp["tarih"] + " - " + etk_temp["baslangic_saati"];

            int knmsSay = etkinkikKonusmacilari.Rows.Count;
            for (int i = 0; i < knmsSay; i++)
            {
                this.etkBanerDetayLab.Text += (i > 0) ?
                " | " + etkinkikKonusmacilari.Rows[i]["konusmaciAdi"] :
                "\n" + etkinkikKonusmacilari.Rows[i]["konusmaciAdi"];
            }


            this.girisLab.Text = etk_temp["giris"].ToString(); 
            this.biletSayLab.Text = "Rezerve edilmiş Sandalye : " + etkinkikbiletleri.Rows.Count + " | Kalan Yer : " 
                + (Convert.ToInt32(etk_temp["koltuk_sayisi"].ToString()) - etkinkikbiletleri.Rows.Count);
            this.biletlerGridView.DataSource = etkinkikbiletleri;

        }

        private void etkVeriYukle()
        {
            //etkinlik
            this.etkinkik = Sorgular.oku(
                @"
                   SELECT 
                        etkinlik.id, etkinlik.baslik,DATE_FORMAT(tarih, '%d/%m/%Y') as tarih, etkinlik.konuya_giris_metni AS giris,
                        etkinlik.baslangic_saati, etkinlik.bitis_saati, etkinlik.arka_plan_linki,
                        salon.salon_adi AS salon, salon.koltuk_sayisi, dil.baslik AS etkinlik_dili, tur.baslik AS etkinlik_turu
                    FROM 
                        etkinlikler etkinlik, diller dil, salonlar salon , etkinlik_turleri tur
                    WHERE 
                        etkinlik.salon_id=salon.id AND etkinlik.etkinlik_dili_id=dil.id AND etkinlik.etkinlik_turu_id=tur.id   
                        AND etkinlik.id=" + this.etkId +
                ";"
            );


            //etkinkikKonusmacilari
            this.etkinkikKonusmacilari = Sorgular.oku(
                @"
                    SELECT
                        etkinlikKonusmaci.id AS etkKonusmaciId, etkinlikler.id AS etkinlikID, konusmaci.id AS konusmaciId,
                        CONCAT(konusmaci.ad,' ',konusmaci.soyad) AS konusmaciAdi
                    FROM
                        etkinliklerin_konusmacilari AS etkinlikKonusmaci, etkinlikler, konusmacilar AS konusmaci
                    WHERE
                        etkinlikKonusmaci.etkinlik_id=etkinlikler.id AND etkinlikKonusmaci.konusmaci_id=konusmaci.id   
                        AND etkinlikler.id=" + this.etkId +
                ";"
            );


            //etkinkikCanliBaglantilari
            this.etkinkikCanliBaglantilari = Sorgular.oku(
                @"
                    SELECT
                        ecb.id, etkinlikler.id AS etkinlikID, ecb.baglanti
                    FROM
                        etkinlik_canli_baglantilari AS ecb, etkinlikler
                    WHERE
                        ecb.etkinlik_id=etkinlikler.id    
                        AND etkinlikler.id=" + this.etkId +
                ";"
            );


            //etkinkikBilgiAlanlari
            this.etkinkikBilgiAlanlari = Sorgular.oku(
                @"
                    SELECT
                        bilgi_alanlari.baslik AS bilgiAlani
                    FROM
                        etkinliklerin_yonelik_olduklari_bilgi_alanlari AS eyba, etkinlikler, bilgi_alanlari
                    WHERE
                        eyba.etkinlik_id=etkinlikler.id AND eyba.bilgi_alani_id=bilgi_alanlari.id     
                        AND etkinlikler.id=" + this.etkId +
                ";"
            );

            //etkinkikbiletleri
            this.etkinkikbiletleri = Sorgular.oku(
                @"
                    SELECT
                        CONCAT('Blt-',biletler.id) AS 'Bilet Numarası',  CONCAT('Etklk-', etkinlikler.id) AS 'Etkinlik Kodu', CONCAT('Uye-', uyeler.id,' ', uyeler.ad, ' ' , uyeler.soyadi) AS 'Üye'
                    FROM
                        biletler, etkinlikler, uyeler, etkinlik_turleri, diller, salonlar
                    WHERE
                        biletler.etkinlik_id=etkinlikler.id AND biletler.uye_id=uyeler.id 
                        AND etkinlikler.etkinlik_turu_id=etkinlik_turleri.id 
                        AND etkinlikler.etkinlik_dili_id=diller.id AND etkinlikler.salon_id=salonlar.id 
                        AND etkinlikler.id=" + this.etkId +
                ";"
            );


            //detaylar
            DataTable detDT = Sorgular.oku(
                @"
                    SELECT 
                        CONCAT('Etklk-',etkinlik.id) AS Kod, DATE_FORMAT(tarih, '%d/%m/%Y') as tarih,
                        etkinlik.baslangic_saati AS 'Başlangıç Saati', etkinlik.bitis_saati  AS 'Bitiş Saati',
                        salon.salon_adi AS Salon, salon.koltuk_sayisi, dil.baslik AS Dil, tur.baslik AS etkinlik_turu
                    FROM 
                        etkinlikler etkinlik, diller dil, salonlar salon , etkinlik_turleri tur
                    WHERE 
                        etkinlik.salon_id=salon.id AND etkinlik.etkinlik_dili_id=dil.id AND etkinlik.etkinlik_turu_id=tur.id   
                        AND etkinlik.id=" + this.etkId +
                ";"
            );

            DataRow temp = detDT.Rows[0];
            det =
                "Kod : " + temp["Kod"] + "\n" +
                "Tarih : " + temp["tarih"] + "\n" +
                "Başlangıç Saati : " + temp["Başlangıç Saati"] + "\n" +
                "Bitiş Saati : " + temp["Bitiş Saati"] + "\n" +
                "Salon : " + temp["Salon"] + "\n" +
                "koltuk Sayisi : " + temp["koltuk_sayisi"] + "\n" +
                "Dil : " + temp["Dil"] + "\n" +
                "Etkinlik türü : " + temp["etkinlik_turu"] + "\n"
            ;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Form etkinlikEkleForm = new EtkinlikEkleDuzeltPopUp(etkId);
            etkinlikEkleForm.ShowDialog();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string baslik = "Onaylama";
            string mesage = "Silme işlemin geri dönüşü yoktur.\n (Etklk-" +etkId + ") numaralı Etkinlik, dil bilgileri, favori etkinlikler ...etc her şey silinecektir.";
            MessageBoxButtons Butonlar = MessageBoxButtons.YesNo;
            DialogResult onay = MessageBox.Show(mesage, baslik, Butonlar, MessageBoxIcon.Warning);
            if (onay == DialogResult.Yes)
            {
                try
                {
                    Sorgular.ekle_guncele_sil("DELETE FROM etkinlikler WHERE id=" + etkId);
                    Program.anaForm.yeniFormYukle(new EtkinliklerForm());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Oluştu : " + ex.Message);
                }
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            Form esaForm = new BiletSatinAlma(etkId);
            esaForm.ShowDialog();
        }
    }

}
