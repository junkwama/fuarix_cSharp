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
    public partial class KotrolPaneliForm : Form
    {

        private KpanelVerileri veriler = new KpanelVerileri();
        public KotrolPaneliForm()
        {
            InitializeComponent();
            kotrolPaneliGuncele();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );



        public void kotrolPaneliGuncele()
        {
            //İstatistiskler Grup 1
            this.veriler.veriTabanindaAlma();
            etkinlikSayiValue.Text = this.veriler.etkinlikSayisi.ToString().PadLeft(5, '0');
            uyeSayiValue.Text = this.veriler.uyeSayisi.ToString().PadLeft(5, '0');
            tmmEtkSayiValue.Text = this.veriler.tmmEtkinlikSayisi.ToString().PadLeft(5, '0');
            konusmaciSayiValue.Text = this.veriler.konusmaciSayisi.ToString().PadLeft(5, '0');
            yoneticiSayiValue.Text = this.veriler.yoneticiSayisi.ToString().PadLeft(5, '0');
            biletSayiValue.Text = this.veriler.biletlerSayisi.ToString().PadLeft(5, '0');
            mevcutEtkSayiValue.Text = this.veriler.mevcutEtkSayi.ToString().PadLeft(5, '0');


            //Öne Çıkan etkinlikler DataView
            oneCikanEtklikGV.DataSource = this.veriler.oneCikenEkinlikler;


            //Bar Grup : etkinlik Turune Göre Biletler Sayısı
            etkinlikTuruVeBiletChar.DataSource = this.veriler.etkinlikTuruVeEtkinlik;
            etkinlikTuruVeBiletChar.Series[0].XValueMember = "Key";
            etkinlikTuruVeBiletChar.Series[0].YValueMembers = "Value";
            etkinlikTuruVeBiletChar.DataBind();

            //Pie etkinlik Turune Göre Etkinlik Sayisi
            etkinlikTuruVeEtkinlikChart.DataSource = this.veriler.etkinlikTuruVeBilet;
            etkinlikTuruVeEtkinlikChart.Series[0].XValueMember = "Key";
            etkinlikTuruVeEtkinlikChart.Series[0].YValueMembers = "Value";
            etkinlikTuruVeEtkinlikChart.DataBind();

        }

        private void Kpaneli_Load(object sender, EventArgs e)
        {

            // Bazı bileşenlerin Görünümleri sıfırlaması (Round etmek gibi işlemler)
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 15, 15));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 15, 15));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 15, 15));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 15, 15));

            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 15, 15));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 15, 15));

            oneCikanEtklikGV.Columns["Konu"].Width = 300;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       
    }
}
