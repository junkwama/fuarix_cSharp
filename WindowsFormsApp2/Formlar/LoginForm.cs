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
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class LoginForm : Form
    {
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
        public LoginForm()
        {
            InitializeComponent();
        }
        
        bool loginFormIsValid()
        {
            sifreErrLab.Text = "";
            epostaErrLab.Text = "";
            sifreErrLab.Visible = false;
            epostaErrLab.Visible = false;

            List<ItemToValide> itemsToValidate = new List<ItemToValide>();
            itemsToValidate.Add(new ItemToValide(epostaTextBox.Text.Trim(), "email", "Eposta", epostaErrLab));
            itemsToValidate.Add(new ItemToValide(sifreTextBox.Text.Trim(), "password", "Şifre", sifreErrLab));
            string validationMetni = Validation.check(itemsToValidate);
            if (validationMetni == "valid")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            sifreErrLab.Text = "";
            epostaErrLab.Text = "";
            sifreErrLab.Visible = false;
            epostaErrLab.Visible = false;

            loginPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, loginPanel.Width, loginPanel.Height, 20, 20));
            logo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, logo.Width, logo.Height, 75, 75));

            epostaTextBox.Select();
        }

        private void girisYapBut_Click(object sender, EventArgs e)
        {
            if (loginFormIsValid())
            {
                DataTable eposta_arat_DT = Sorgular.oku("SELECT * FROM yoneticiler WHERE email='"+ epostaTextBox.Text.Trim() + "'");
                if (eposta_arat_DT.Rows.Count > 0)
                {
                    DataTable sifre_tontrol_et_DT = Sorgular.oku("SELECT * FROM yoneticiler WHERE email='" + epostaTextBox.Text.Trim() + "' AND sifre='" + sifreTextBox.Text.Trim() + "'");
                    if (sifre_tontrol_et_DT.Rows.Count > 0)
                    {
                        //Her Şey yolunday ise Hesap açıyoruz
                        DataRow yonetici = sifre_tontrol_et_DT.Rows[0];

                        Program.aktifYonetici = new Yonetici(
                            yonetici["id"].ToString(),
                            yonetici["ad"].ToString(),
                            yonetici["soyad"].ToString(),
                            yonetici["email"].ToString(),
                            yonetici["tel"].ToString(),
                            yonetici["sifre"].ToString()
                        );

                        //MessageBox.Show(Program.aktifYonetici.ad + " " + Program.aktifYonetici.soyad);

                        //KontrolPaneliForm kontroPanel = new KontrolPaneliForm();
                        //kontroPanel.Show();
                        //this.Hide();

                        this.Hide();
                        AnaForm kontroPanel = new AnaForm();
                        kontroPanel.Closed += (s, args) => this.Close();
                        kontroPanel.Show();

                    }
                    else
                    {
                        sifreErrLab.Visible = true;
                        sifreErrLab.Text = "Şifre Yanlış";
                    }
                }
                else
                {
                    epostaErrLab.Visible = true;
                    epostaErrLab.Text = "Hesap Bulunamadı";

                }

            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
