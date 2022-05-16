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
    public partial class Uye : UserControl
    {
        //Stact overflow'dan (rouded border oluşturmak için)---------------//
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
            set { _id = value; }
        }

        [Category("Custom Props")]
        private string _adlar;
        public string adlar
        {
            get { return _adlar; }
            set { _adlar = value; this.adLab.Text = value; }
        }

        [Category("Custom Props")]
        private string _infBlok2;
        public string infBlok2
        {
            get { return _infBlok2; }
            set { _infBlok2 = value; this.blk2Lab.Text = value; }
        }
        
        [Category("Custom Props")]
        private string _grpDil;
        public string grpDil
        {
            get { return _grpDil; }
            set { _grpDil = value; grpDilLab.Text = value; }
        }
        
        [Category("Custom Props")]
        private string _grpBilgi;
        public string grpBilgi
        {
            get { return _grpBilgi; }
            set { _grpBilgi = value; grpBilgiLab.Text = value; }
        }

        public Uye()
        {
            InitializeComponent();
            //Rounded tasarım
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 10, 10));
            this.blk2Lab.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, blk2Lab.Width, blk2Lab.Height, 10, 10));
            this.grpDilLab.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, grpDilLab.Width, grpDilLab.Height, 10, 10));
            this.grpBilgiLab.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, grpDilLab.Width, grpDilLab.Height, 10, 10));
            this.pictureBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 20, 20));
            //--------

            //Rengi
            Color[] renklerPrimary = { Color.FromArgb(140,1,143), Color.FromArgb(0,21,181), Color.FromArgb(11,150,13), Color.FromArgb(212,194,2), Color.FromArgb(194,4,80) };
            Color[] renklerSecondary = { Color.FromArgb(252,210,252), Color.FromArgb(204,210,255), Color.FromArgb(214,255,215), Color.FromArgb(255,255,214), Color.FromArgb(247,198,218) };

            //Primary
            int col = (new Random()).Next(0,4);
            this.BackColor = renklerPrimary[col];
            this.pictureBox1.BackColor = renklerPrimary[col];
            this.grpDilLab.BackColor = renklerPrimary[col];
            this.grpBilgiLab.BackColor = renklerPrimary[col];
            //secondary
            this.panel2.BackColor = renklerSecondary[col];
            this.panel1.BackColor = renklerSecondary[col];
            this.blk2Lab.BackColor = renklerSecondary[col];

        }

        private void Uye_Load(object sender, EventArgs e)
        {

        }

        private void gunceleBut_Click(object sender, EventArgs e)
        {
            Form uyeEkleForm = new UyeEkleDuzeltPopUpForm(this._id);
            uyeEkleForm.ShowDialog();
        }

        private void uyeSilBut_Click(object sender, EventArgs e)
        {
            string baslik = "Onaylama";
            string mesage = "Silme işlemin geri dönüşü yoktur.\n (Uye-" + this._id + ") numaralı uye, dil bilgileri, favori etkinlikler ...etc her şey silinecektir.";
            MessageBoxButtons Butonlar = MessageBoxButtons.YesNo;
            DialogResult onay = MessageBox.Show(mesage, baslik, Butonlar , MessageBoxIcon.Warning);
            if (onay == DialogResult.Yes)
            {
                try
                {
                    Sorgular.ekle_guncele_sil("DELETE FROM uyeler WHERE id=" + this._id);
                    Program.anaForm.yeniFormYukle(new UyelerForm());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Oluştu : " + ex.Message);
                }
            }
        }
    }
}
