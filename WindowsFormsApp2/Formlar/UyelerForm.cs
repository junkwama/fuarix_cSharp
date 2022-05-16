using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UyelerForm : Form
    {
        public DataTable uyeler;
        public UyelerForm()
        {
            InitializeComponent();
        }

        private void UyelerForm_Load(object sender, EventArgs e)
        {
            uyeler_yukle();
        }

        public void uyeler_yukle()
        {
            uyeler_Guncele();
            Uye uye_item;
            DataRow uyelerRow;
            int itkSaye = uyeler.Rows.Count;
            for (int i = 0; i < itkSaye; i++)
            {
                //Ad Soya email ..etc
                uyelerRow = uyeler.Rows[i];
                uye_item = new Uye();
                uye_item.id = Convert.ToInt32(uyelerRow["id"].ToString());
                uye_item.adlar = uyelerRow["uyeAdlari"].ToString();
                uye_item.infBlok2 = uyelerRow["addBilgi"].ToString();

                //dilleri
                DataTable uyeDilleri = Sorgular.oku(
                    @"
                        SELECT
                            dil.baslik AS dil, uye.id AS uyeId
                        FROM
                            uyelerin_dilleri, diller dil, uyeler uye 
                        WHERE
                            uyelerin_dilleri.dil_id = dil.id AND uyelerin_dilleri.uye_id=uye.id
                        AND uye.id=" + Convert.ToInt32(uyelerRow["id"].ToString()) +
                    ";"
                );

                int dilSay = uyeDilleri.Rows.Count;
                for (int j = 0; j < dilSay; j++)
                {
                    uye_item.grpDil += (j == 0) ? uyeDilleri.Rows[j]["dil"].ToString() :
                        " / " + uyeDilleri.Rows[j]["dil"];
                }

                //Fav Bilgi Alanlari
                DataTable uyeFavBil = Sorgular.oku(
                    @"
                        SELECT
                            kb_alan.id, bilgi_alani.baslik AS bilgiAlani, uyeler.id AS uyeId
                        FROM
                            uyelerin_favori_bilgi_alanlari AS kb_alan, bilgi_alanlari AS bilgi_alani, uyeler
                        WHERE
                            kb_alan.bilgi_alani_id=bilgi_alani.id AND kb_alan.uye_id=uyeler.id
                        AND uyeler.id=" + Convert.ToInt32(uyelerRow["id"].ToString()) +
                    ";"
                );

                int bilgiSay = uyeFavBil.Rows.Count;
                for (int j = 0; j < bilgiSay; j++)
                {
                    uye_item.grpBilgi += " #" + uyeFavBil.Rows[j]["bilgiAlani"];
                }

                //Uyeyi flowControl Panele Ekliyoruz
                this.uyelerFlowPanel.Controls.Add(uye_item);
            }
        }

        public void uyeler_Guncele()
        {
            uyeler = Sorgular.oku(
                @"
                    SELECT 
                        uye.id, CONCAT( uye.ad , ' ' , uye.soyadi, '\n', uye.email ,' / (Uye-', uye.id, ')' ) AS uyeAdlari, 
                        CONCAT(meslek.baslik, '\n', ulke.isim, ' - ' , uye.sehir, '\n', uye.tel ) AS addBilgi
                    FROM 
                        uyeler uye, meslekler meslek, ulkeler ulke 
                    WHERE 
                        uye.ulke_id=ulke.id AND uye.meslek_id=meslek.id
                    ORDER BY id DESC;
                "
            );
        }

        private void uyeEkle_Click(object sender, EventArgs e)
        {
            Form uyeEkleForm = new UyeEkleDuzeltPopUpForm();
            uyeEkleForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
