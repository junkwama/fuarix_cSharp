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

namespace WindowsFormsApp2
{
    public partial class AnaForm : Form
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


        public AnaForm()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void KontrolPaneliForm_Load(object sender, EventArgs e)
        {

            Program.anaBolgePaneli = this.anaBolgePaneli;
            Program.anaForm = this;

            Yonetici yntc = Program.aktifYonetici;
            this.yoneticiBilgileriLab.Text = yntc.ad + " " + yntc.soyad + "\n" + yntc.kod + "\n" + yntc.eposta;

            //ilk form KontrolPaneli form olsun
            kontrolPaneliBut.BackColor = Color.FromArgb(55, 0, 70);
            kontrolPaneliBut.ForeColor = Color.FromArgb(236, 185, 249);
            kontrolPaneliBut.Select();
            yeniFormYukle(new KotrolPaneliForm());

        }

        public void yeniFormYukle(object YuklenecekForm )
        {
            //ilk olarak anaBolgePaneliyi boşaltiyoruz
            if (this.anaBolgePaneli.Controls.Count > 0)
            {
                this.anaBolgePaneli.Controls.RemoveAt(0);
            }

            Form frm = YuklenecekForm as Form;
            //Yuklenecek anaBolgePaneli'nin öne çıkartalaım ve Dock fill ile tam bölge kaplasın
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            //anaBolgePaneli'nin elemanı olarak yukleyelim
            this.anaBolgePaneli.Controls.Add(frm);

            //anaBolgePaneli'nin veri set edelim
            this.anaBolgePaneli.Tag = frm;
            frm.Show();

        }

        //Menin aktif olan item'i Style faklılaştırmak için Focus ve Blur olayları kullanacagız

        //Kontrol Panelin Buton : Click - Focus - Blur Olayları -----------------
        private void kontrolPaneliBut_Click(object sender, EventArgs e)
        {
            yeniFormYukle(new KotrolPaneliForm());
        }
        private void kontrolPaneliBut_Focus(object sender, EventArgs e)
        {
            menu_buts_blur_all();
            kontrolPaneliBut.BackColor = Color.FromArgb(55, 0, 70);
            kontrolPaneliBut.ForeColor = Color.FromArgb(236, 185, 249);
        }

        //----------------------------

        //Etkinlikler Buton : Click - Focus - Blur Olayları -----------------
        private void etkinliklerBut_Click(object sender, EventArgs e)
        {
            yeniFormYukle(new EtkinliklerForm());
        }
        private void etkinliklerBut_Focus(object sender, EventArgs e)
        {
            menu_buts_blur_all();
            etkinliklerBut.BackColor = Color.FromArgb(55, 0, 70);
            etkinliklerBut.ForeColor = Color.FromArgb(236, 185, 249);
        }
        //-----------------------------------

        //Uyeler Buton : Click - Focus - Blur Olayları -----------------
        private void uyelerBut_Click(object sender, EventArgs e)
        {
            yeniFormYukle(new UyelerForm());
        }
        private void uyelerBut_Focus(object sender, EventArgs e)
        {
            menu_buts_blur_all();
            uyelerBut.BackColor = Color.FromArgb(55, 0, 70);
            uyelerBut.ForeColor = Color.FromArgb(236, 185, 249);
        }
        //------------------

        //Konuşmacilar Buton : Click - Focus - Blur Olayları -----------------
        private void konusmacilarBut_Click(object sender, EventArgs e)
        {
            yeniFormYukle(new KonusmacilarForm());
        }
        private void konusmacilarBut_Focus(object sender, EventArgs e)
        {
            menu_buts_blur_all();
            konusmacilarBut.BackColor = Color.FromArgb(55, 0, 70);
            konusmacilarBut.ForeColor = Color.FromArgb(236, 185, 249);
        }
        //------------------

        //Biletler Buton : Click - Focus - Blur Olayları -----------------
        private void biletlerBut_Click(object sender, EventArgs e)
        {
            yeniFormYukle(new BiletlerForm());
        }
        private void biletlerBut_Focus(object sender, EventArgs e)
        {
            menu_buts_blur_all();
            biletlerBut.BackColor = Color.FromArgb(55, 0, 70);
            biletlerBut.ForeColor = Color.FromArgb(236, 185, 249);
        }
        //------------------

        //Biletler Buton : Click - Focus - Blur Olayları -----------------
        private void salonlarBut_Click(object sender, EventArgs e)
        {
            yeniFormYukle(new SalonlarForm());
        }
        private void salonlarBut_Focus(object sender, EventArgs e)
        {
            menu_buts_blur_all();
            salonlarBut.BackColor = Color.FromArgb(55, 0, 70);
            salonlarBut.ForeColor = Color.FromArgb(236, 185, 249);
        }
        //------------------

        private void menu_buts_blur_all()
        {
            salonlarBut.BackColor = Color.FromArgb(236, 185, 249);
            salonlarBut.ForeColor = Color.FromArgb(55, 0, 70);

            biletlerBut.BackColor = Color.FromArgb(236, 185, 249);
            biletlerBut.ForeColor = Color.FromArgb(55, 0, 70);

            konusmacilarBut.BackColor = Color.FromArgb(236, 185, 249);
            konusmacilarBut.ForeColor = Color.FromArgb(55, 0, 70);

            uyelerBut.BackColor = Color.FromArgb(236, 185, 249);
            uyelerBut.ForeColor = Color.FromArgb(55, 0, 70);

            etkinliklerBut.BackColor = Color.FromArgb(236, 185, 249);
            etkinliklerBut.ForeColor = Color.FromArgb(55, 0, 70);

            kontrolPaneliBut.BackColor = Color.FromArgb(236, 185, 249);
            kontrolPaneliBut.ForeColor = Color.FromArgb(55, 0, 70);
        }

    }
}
