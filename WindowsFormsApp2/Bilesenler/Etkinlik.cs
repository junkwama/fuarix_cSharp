using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Bilesenler
{
    public partial class Etkinlik : UserControl
    {
        [Category("Custom Props")]
        private string _konuValu;
        public string konuValue{
            get { return _konuValu; }
            set { _konuValu = value; konuLab.Text = value; }
        }

        [Category("Custom Props")]
        private string _etkTuruValue;
        public string etkTuruValue
        {
            get { return _etkTuruValue; }
            set { _etkTuruValue = value; etkTuruLab.Text = value; }
        }

        [Category("Custom Props")]
        private string _tarihValue;
        public string tarihValue
        {
            get { return _tarihValue; }
            set { _tarihValue = value; tarihLab.Text = value; }
        }

        [Category("Custom Props")]
        private string _etk_bg_linki_value;
        public string etk_bg_linki_value
        {
            get { return _etk_bg_linki_value; }
            set { _etk_bg_linki_value = value; pictureBox1.ImageLocation = value; }
        }

        [Category("Custom Props")]
        private int _etkId;
        public int etkId
        {
            get { return _etkId; }
            set { _etkId = value; }
        }

        public Label etkTuruLabGet
        {
            get { return this.etkTuruLab; }
        }
        //

        public Etkinlik()
        {
            InitializeComponent();
        }

        private void Etkinlik_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.konuLab.BackColor = Color.FromArgb(240, 240, 240);
            this.tarihLab.BackColor = Color.White;
            this.konuLab.ForeColor = Color.Black;
            this.tarihLab.ForeColor = Color.Gray;
        }

        private void Etkinlik_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.BlueViolet;
            this.konuLab.BackColor = Color.BlueViolet;
            this.tarihLab.BackColor = Color.BlueViolet;
            this.konuLab.ForeColor = Color.White;
            this.tarihLab.ForeColor = Color.White;
        }

        private void _butForClick_Click()
        {
            
            //ilk olarak anaBolgePaneliyi boşaltiyoruz
            if (Program.anaBolgePaneli.Controls.Count > 0)
            {
                Program.anaBolgePaneli.Controls.RemoveAt(0);
            }

            Form frm = new EtkinlikDetaylariForm(this.etkId) as Form;
            //Yuklenecek anaBolgePaneli'nin öne çıkartalaım ve Dock fill ile tam bölge kaplasın
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            //anaBolgePaneli'nin elemanı olarak yukleyelim
            Program.anaBolgePaneli.Controls.Add(frm);

            //anaBolgePaneli'nin veri set edelim
            Program.anaBolgePaneli.Tag = frm;
            frm.Show();
        }
        private void etk_Click(object sender, EventArgs e)
        {
            _butForClick_Click();
        }

        private void Etkinlik_Load(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {
            Form etkinlikEkleForm = new EtkinlikEkleDuzeltPopUp(this._etkId);
            etkinlikEkleForm.ShowDialog();
        }
    }
}
