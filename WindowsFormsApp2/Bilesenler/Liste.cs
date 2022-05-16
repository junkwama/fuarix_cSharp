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
    public partial class Liste : UserControl
    {

        public DataTable data;
        public string baslik;

        public Liste()
        {
            InitializeComponent();
        }

        private void Liste_Load(object sender, EventArgs e)
        {
            title.Text = this.baslik;
            listContent.DataSource = this.data;

        }
    }
}
