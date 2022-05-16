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
    public partial class BiletlerForm : Form
    {
        public BiletlerForm()
        {
            InitializeComponent();

            DataTable biletLerDT;
            Bilesenler.Liste list;
            DataTable etkinlikler = Sorgular.oku("SELECT id, baslik FROM etkinlikler ORDER BY tarih DESC");
            int etkinlikSayi = etkinlikler.Rows.Count;


            for (int i = 0; i < etkinlikSayi; i++)
            {
                biletLerDT = Sorgular.oku(
                    @"
                        SELECT
                            CONCAT('Blt-',biletler.id) AS 'Bilet Numarası',  CONCAT('Etklk-', etkinlikler.id) AS 'Etkinlik Kodu', CONCAT('Uye-', uyeler.id,' ', uyeler.ad, ' ' , uyeler.soyadi) AS 'Üye'
                        FROM
                            biletler, etkinlikler, uyeler, etkinlik_turleri, diller, salonlar
                        WHERE
                            biletler.etkinlik_id=etkinlikler.id AND biletler.uye_id=uyeler.id 
                            AND etkinlikler.etkinlik_turu_id=etkinlik_turleri.id 
                            AND etkinlikler.etkinlik_dili_id=diller.id AND etkinlikler.salon_id=salonlar.id 
                            AND etkinlikler.id=" + Convert.ToInt32(etkinlikler.Rows[i]["id"].ToString()) +
                    ";"
                );

                //etkinlikler.Rows[etkinlikSayi]["id"].ToString()
                list = new Bilesenler.Liste();

                list.baslik = etkinlikler.Rows[i]["baslik"].ToString();
                list.data = biletLerDT;

                kontener.Controls.Add(list);
            }



        }
        




        private void BiletlerForm_Load(object sender, EventArgs e)
        {
           
        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
