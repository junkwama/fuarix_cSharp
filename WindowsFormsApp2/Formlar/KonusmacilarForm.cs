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
    public partial class KonusmacilarForm : Form
    {
        private DataTable konumacilar;
        public KonusmacilarForm()
        {
            InitializeComponent();
            konumacilarGuncele();
        }

        private void KonusmacilarForm_Load(object sender, EventArgs e)
        {
            etkinlikler_yukle();
        }

        public void etkinlikler_yukle()
        {
            
            Bilesenler.Konusmaci konusmaci_item;
            DataRow konusmaciRow;
            int itkSaye = konumacilar.Rows.Count;
            for (int i = 0; i < itkSaye; i++)
            {
                konusmaciRow = konumacilar.Rows[i];
                konusmaci_item = new Bilesenler.Konusmaci();

                konusmaci_item.konusmaciAd  = konusmaciRow["tamAdi"].ToString();
                konusmaci_item.konumaciHakkinda = konusmaciRow["hakkinda"].ToString();
                konusmaci_item.konusmaciDetaylari = konusmaciRow["dataylar"].ToString();
                konusmaci_item.site = konusmaciRow["internet_sitesi"].ToString();
                konusmaci_item.id = Convert.ToInt32(konusmaciRow["id"].ToString());
                if (konusmaciRow["profil"].ToString() != "NULL")
                {
                    konusmaci_item.profileLink = konusmaciRow["profil"].ToString();
                }
                this.konusmacilarFlowPanel.Controls.Add(konusmaci_item);

            }

        }

        public void konumacilarGuncele()
        {
            konumacilar = Sorgular.oku(
                @"
                SELECT
                    CONCAT(ad, ' ', soyad, ' (KNMC-', konusmaci.id, ')') AS tamAdi, profil, hakkinda, internet_sitesi, konusmaci.id,
                    CONCAT('Eposta : ', email, ' / ', 'Tel : ', tel, ' / Kurum : ', kurum, ' - ', kurum_gorevi , ' / Meslek : ', meslek.baslik, ' / Ülke' ,  ulke.isim, ' - ', sehir) AS dataylar
                FROM
                    konusmacilar konusmaci, ulkeler ulke, bilgi_alanlari bilgiAlani, meslekler meslek
                WHERE
                    konusmaci.ana_bilgi_alani_id=bilgiAlani.id AND konusmaci.meslek_id=meslek.id AND konusmaci.ulke_id=ulke.id;
                "
            );
        }

        private void konusmaciEkleBut_Click(object sender, EventArgs e)
        {
            Form konusmaciEkleForm = new KonusmaciEkleDuzeltFormPopUp();
            konusmaciEkleForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
