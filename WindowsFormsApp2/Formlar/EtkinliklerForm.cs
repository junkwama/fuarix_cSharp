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
    public partial class EtkinliklerForm : Form
    {
        public DataTable etkinlikler;
        public EtkinliklerForm()
        {
            InitializeComponent();
            etkinliklerGuncele();
        }

        private void EtkinliklerForm_Load(object sender, EventArgs e)
        {
            etkinlikler_yukle();
        }

        public void etkinlikler_yukle()
        {
            //etkinliklerGuncele();
            Etkinlik etkinlikler_item;
            DataRow etkRow;
            string etk_linki;
            int itkSaye = etkinlikler.Rows.Count;
            for (int i = 0; i < itkSaye; i++)
            {
                etkRow = etkinlikler.Rows[i];
                etkinlikler_item = new Etkinlik();

                    etkinlikler_item.etkTuruValue = etkRow["etkinlik_turu"].ToString();
                    etkinlikler_item.konuValue = etkRow["baslik"].ToString(); 
                    etkinlikler_item.tarihValue = etkRow["tarih"].ToString();
                    etkinlikler_item.etkId = Convert.ToInt32(etkRow["id"].ToString());

                etk_linki = etkRow["arka_plan_linki"].ToString();
                    if (etk_linki.Length > 0 && etk_linki != "null")
                    {
                        etkinlikler_item.etk_bg_linki_value = etk_linki;
                    }

                    switch (etkRow["etkinlik_turu"])
                    {
                        case "Kongre":
                            etkinlikler_item.etkTuruLabGet.BackColor = Color.PaleVioletRed;
                            break;
                        case "Konferans":
                            etkinlikler_item.etkTuruLabGet.BackColor = Color.BlueViolet;
                            break;
                        case "Seminer":
                            etkinlikler_item.etkTuruLabGet.BackColor = Color.FromArgb(0, 204, 143);
                            break;
                        case "Sympozyum":
                            etkinlikler_item.etkTuruLabGet.BackColor = Color.FromArgb(255, 51, 153);
                            break;
                    }

                    etkinliklerFlowPanel.Controls.Add(etkinlikler_item);
            }
            
        }

        public void etkinliklerGuncele()
        {
            etkinlikler = Sorgular.oku(
                @"
                SELECT 
		            etkinlik.id, etkinlik.baslik,
                    CONCAT(DATE_FORMAT(etkinlik.tarih,'%d/%m/%Y'), ' ' , etkinlik.baslangic_saati)  as tarih, 
                    etkinlik.arka_plan_linki, dil.baslik AS etkinlik_dili, tur.baslik AS etkinlik_turu
                FROM 
		            etkinlikler etkinlik, diller dil, etkinlik_turleri tur
                WHERE 
		            etkinlik.etkinlik_dili_id=dil.id AND etkinlik.etkinlik_turu_id=tur.id ORDER BY etkinlik.tarih DESC
                "
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void konusmaciEkleBut_Click(object sender, EventArgs e)
        {
            Form etkinlikEkleForm = new EtkinlikEkleDuzeltPopUp();
            etkinlikEkleForm.ShowDialog();
        }
    }
}
