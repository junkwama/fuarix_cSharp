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
    public partial class Koltuk : UserControl
    {
        public string koltukID;
        public Label secilen_koltuk_label;
        public Color bg;
        public Koltuk(Label secilen_koltuk_label_param)
        {
            InitializeComponent();
            button1.BackColor = Color.SeaShell;
            secilen_koltuk_label=secilen_koltuk_label_param;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secilen_koltuk_label.Text = this.koltukID;
        }

        private void Koltuk_Load(object sender, EventArgs e)
        {
            button1.Text = this.koltukID;
            button1.BackColor = bg;
        }
    }
}
