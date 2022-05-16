using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class SalonlarForm : Form
    {
        public SalonlarForm()
        {
            InitializeComponent();


            DataTable salonlarDT;
            Bilesenler.Liste list;
            DataTable salonlar = Sorgular.oku("SELECT * FROM salonlar");
            int salonlarSayi = salonlar.Rows.Count;


            for (int i = 0; i < salonlarSayi; i++)
            {
                salonlarDT = Sorgular.oku(
                    @"SELECT baslik, tarih FROM etkinlikler WHERE salon_id=" + Convert.ToInt32(salonlar.Rows[i]["id"].ToString()) 
                ); 

                //salonlar.Rows[salonlarSayi]["id"].ToString()
                list = new Bilesenler.Liste();

                list.baslik = salonlar.Rows[i]["salon_adi"].ToString();
                list.data = salonlarDT;

                kontener.Controls.Add(list);
            }

        }

        private void SalonlarForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
