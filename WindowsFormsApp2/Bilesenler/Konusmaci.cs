using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp2.Bilesenler
{
    public partial class Konusmaci : UserControl
    {
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

        [Category("Custom Props")]
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value;}
        }

        [Category("Custom Props")]
        private string _konusmaciAdi;
        public string konusmaciAd
        {
            get { return _konusmaciAdi; }
            set { _konusmaciAdi = value; adiLab.Text = value; }
        }

        [Category("Custom Props")]
        private string _konumaciHakkinda;
        public string konumaciHakkinda
        {
            get { return _konumaciHakkinda; }
            set { _konumaciHakkinda = value; aboutLab.Text = value; }
        }

        [Category("Custom Props")]
        private string _konusmaciDetaylari;
        public string konusmaciDetaylari
        {
            get { return _konusmaciDetaylari; }
            set { _konusmaciDetaylari = value; detailsLab.Text = value; }
        }

        [Category("Custom Props")]
        private string _profileLink;
        public string profileLink
        {
            get { return _profileLink; }
            set { _profileLink = value; profileLab.ImageLocation = value; }
        }

        [Category("Custom Props")]
        private string _site;
        public string site
        {
            get { return _site; }
            set { _site = value; this.siteLink.Links.Add(0, 24, value); }
        }
        
        public Konusmaci()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.container.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            this.siteLink.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void gunceleBut_Click(object sender, EventArgs e)
        {
            Form konusmaciEkleForm = new KonusmaciEkleDuzeltFormPopUp(this._id);
            konusmaciEkleForm.ShowDialog();
        }

        private void silBut_Click(object sender, EventArgs e)
        {
            string baslik = "Onaylama";
            string mesage = "Silme işlemin geri dönüşü yoktur.\n(Knmc-" + this._id + ") numaralı Kunuşmacı, dil bilgileri, yaptiği etkinlikleri ...etc her şey silinecektir.";
            MessageBoxButtons Butonlar = MessageBoxButtons.YesNo;
            DialogResult onay = MessageBox.Show(mesage, baslik, Butonlar, MessageBoxIcon.Warning);
            if (onay == DialogResult.Yes)
            {
                try
                {
                    Sorgular.ekle_guncele_sil("DELETE FROM konusmacilar WHERE id=" + this._id);
                    Program.anaForm.yeniFormYukle(new KonusmacilarForm());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Oluştu : " + ex.Message);
                }
            }
        }

        private void Konusmaci_Load(object sender, EventArgs e)
        {

        }
    }
}
