namespace WindowsFormsApp2
{
    partial class EtkinlikEkleDuzeltPopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EtkinlikEkleDuzeltPopUp));
            this.baslik = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.Label();
            this.eposta = new System.Windows.Forms.Label();
            this.etkTuru = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.etkDili = new System.Windows.Forms.ComboBox();
            this.meslekL = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.etkinlikKonusmacilari = new System.Windows.Forms.CheckedListBox();
            this.etkinlikYonBilgiAlan = new System.Windows.Forms.CheckedListBox();
            this.baslikErrLab = new System.Windows.Forms.Label();
            this.tarihErrLab = new System.Windows.Forms.Label();
            this.bitisSaatErrLab = new System.Windows.Forms.Label();
            this.baslangicSaatErrLab = new System.Windows.Forms.Label();
            this.etkTuruErrLab = new System.Windows.Forms.Label();
            this.etkDiliErrLab = new System.Windows.Forms.Label();
            this.etkinlikKonusmacilariErrLab = new System.Windows.Forms.Label();
            this.etkYonBilgiAlanlariErrLab = new System.Windows.Forms.Label();
            this.EkleBut = new WindowsFormsApp2.RJButton();
            this.İptal = new WindowsFormsApp2.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userProfession = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salonCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salonCBErrLab = new System.Windows.Forms.Label();
            this.canliBaglati = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.canliBaglatiErrLab = new System.Windows.Forms.Label();
            this.ozet = new System.Windows.Forms.TextBox();
            this.aaa = new System.Windows.Forms.Label();
            this.ozetErrLab = new System.Windows.Forms.Label();
            this.arkaPlan = new System.Windows.Forms.TextBox();
            this.arkaPlanLink = new System.Windows.Forms.Label();
            this.arkaPlanLinkErrLab = new System.Windows.Forms.Label();
            this.baslangicSaat = new System.Windows.Forms.Label();
            this.bitisSaat = new System.Windows.Forms.DateTimePicker();
            this.etk_baslangicSaat = new System.Windows.Forms.DateTimePicker();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // baslik
            // 
            this.baslik.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslik.Location = new System.Drawing.Point(294, 51);
            this.baslik.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.baslik.MaxLength = 35356356;
            this.baslik.Multiline = true;
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(377, 53);
            this.baslik.TabIndex = 0;
            // 
            // ad
            // 
            this.ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ad.Location = new System.Drawing.Point(293, 28);
            this.ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ad.Name = "ad";
            this.ad.Padding = new System.Windows.Forms.Padding(1);
            this.ad.Size = new System.Drawing.Size(102, 20);
            this.ad.TabIndex = 1;
            this.ad.Text = "Konu";
            // 
            // eposta
            // 
            this.eposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.eposta.Location = new System.Drawing.Point(293, 203);
            this.eposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eposta.Name = "eposta";
            this.eposta.Padding = new System.Windows.Forms.Padding(1);
            this.eposta.Size = new System.Drawing.Size(91, 19);
            this.eposta.TabIndex = 1;
            this.eposta.Text = "Bitiş Saati";
            // 
            // etkTuru
            // 
            this.etkTuru.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etkTuru.FormattingEnabled = true;
            this.etkTuru.Location = new System.Drawing.Point(590, 315);
            this.etkTuru.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.etkTuru.Name = "etkTuru";
            this.etkTuru.Size = new System.Drawing.Size(150, 24);
            this.etkTuru.TabIndex = 2;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label.Location = new System.Drawing.Point(525, 317);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Padding = new System.Windows.Forms.Padding(1);
            this.label.Size = new System.Drawing.Size(47, 19);
            this.label.TabIndex = 1;
            this.label.Text = "Türü";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(846, -115);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 23);
            this.comboBox2.TabIndex = 2;
            // 
            // etkDili
            // 
            this.etkDili.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etkDili.FormattingEnabled = true;
            this.etkDili.Location = new System.Drawing.Point(589, 360);
            this.etkDili.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.etkDili.Name = "etkDili";
            this.etkDili.Size = new System.Drawing.Size(151, 24);
            this.etkDili.TabIndex = 2;
            // 
            // meslekL
            // 
            this.meslekL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.meslekL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meslekL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.meslekL.Location = new System.Drawing.Point(525, 362);
            this.meslekL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meslekL.Name = "meslekL";
            this.meslekL.Padding = new System.Windows.Forms.Padding(1);
            this.meslekL.Size = new System.Drawing.Size(56, 19);
            this.meslekL.TabIndex = 1;
            this.meslekL.Text = "Dil";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(846, -84);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(140, 23);
            this.comboBox4.TabIndex = 2;
            // 
            // etkinlikKonusmacilari
            // 
            this.etkinlikKonusmacilari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.etkinlikKonusmacilari.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etkinlikKonusmacilari.FormattingEnabled = true;
            this.etkinlikKonusmacilari.Location = new System.Drawing.Point(19, 326);
            this.etkinlikKonusmacilari.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.etkinlikKonusmacilari.Name = "etkinlikKonusmacilari";
            this.etkinlikKonusmacilari.Size = new System.Drawing.Size(211, 106);
            this.etkinlikKonusmacilari.TabIndex = 4;
            // 
            // etkinlikYonBilgiAlan
            // 
            this.etkinlikYonBilgiAlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.etkinlikYonBilgiAlan.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etkinlikYonBilgiAlan.FormattingEnabled = true;
            this.etkinlikYonBilgiAlan.Location = new System.Drawing.Point(250, 326);
            this.etkinlikYonBilgiAlan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.etkinlikYonBilgiAlan.Name = "etkinlikYonBilgiAlan";
            this.etkinlikYonBilgiAlan.Size = new System.Drawing.Size(253, 106);
            this.etkinlikYonBilgiAlan.TabIndex = 4;
            // 
            // baslikErrLab
            // 
            this.baslikErrLab.AutoSize = true;
            this.baslikErrLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslikErrLab.ForeColor = System.Drawing.Color.Crimson;
            this.baslikErrLab.Location = new System.Drawing.Point(293, 107);
            this.baslikErrLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baslikErrLab.Name = "baslikErrLab";
            this.baslikErrLab.Size = new System.Drawing.Size(35, 13);
            this.baslikErrLab.TabIndex = 7;
            this.baslikErrLab.Text = "label1";
            this.baslikErrLab.Visible = false;
            // 
            // tarihErrLab
            // 
            this.tarihErrLab.AutoSize = true;
            this.tarihErrLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarihErrLab.ForeColor = System.Drawing.Color.Crimson;
            this.tarihErrLab.Location = new System.Drawing.Point(293, 177);
            this.tarihErrLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tarihErrLab.Name = "tarihErrLab";
            this.tarihErrLab.Size = new System.Drawing.Size(35, 13);
            this.tarihErrLab.TabIndex = 7;
            this.tarihErrLab.Text = "label1";
            this.tarihErrLab.Visible = false;
            // 
            // bitisSaatErrLab
            // 
            this.bitisSaatErrLab.AutoSize = true;
            this.bitisSaatErrLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitisSaatErrLab.ForeColor = System.Drawing.Color.Crimson;
            this.bitisSaatErrLab.Location = new System.Drawing.Point(291, 225);
            this.bitisSaatErrLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bitisSaatErrLab.Name = "bitisSaatErrLab";
            this.bitisSaatErrLab.Size = new System.Drawing.Size(35, 13);
            this.bitisSaatErrLab.TabIndex = 7;
            this.bitisSaatErrLab.Text = "label1";
            this.bitisSaatErrLab.Visible = false;
            // 
            // baslangicSaatErrLab
            // 
            this.baslangicSaatErrLab.AutoSize = true;
            this.baslangicSaatErrLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslangicSaatErrLab.ForeColor = System.Drawing.Color.Crimson;
            this.baslangicSaatErrLab.Location = new System.Drawing.Point(523, 177);
            this.baslangicSaatErrLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baslangicSaatErrLab.Name = "baslangicSaatErrLab";
            this.baslangicSaatErrLab.Size = new System.Drawing.Size(35, 13);
            this.baslangicSaatErrLab.TabIndex = 7;
            this.baslangicSaatErrLab.Text = "label1";
            this.baslangicSaatErrLab.Visible = false;
            // 
            // etkTuruErrLab
            // 
            this.etkTuruErrLab.AutoSize = true;
            this.etkTuruErrLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etkTuruErrLab.ForeColor = System.Drawing.Color.Crimson;
            this.etkTuruErrLab.Location = new System.Drawing.Point(588, 341);
            this.etkTuruErrLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etkTuruErrLab.Name = "etkTuruErrLab";
            this.etkTuruErrLab.Size = new System.Drawing.Size(35, 13);
            this.etkTuruErrLab.TabIndex = 7;
            this.etkTuruErrLab.Text = "label1";
            this.etkTuruErrLab.Visible = false;
            // 
            // etkDiliErrLab
            // 
            this.etkDiliErrLab.AutoSize = true;
            this.etkDiliErrLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etkDiliErrLab.ForeColor = System.Drawing.Color.Crimson;
            this.etkDiliErrLab.Location = new System.Drawing.Point(587, 386);
            this.etkDiliErrLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etkDiliErrLab.Name = "etkDiliErrLab";
            this.etkDiliErrLab.Size = new System.Drawing.Size(35, 13);
            this.etkDiliErrLab.TabIndex = 7;
            this.etkDiliErrLab.Text = "label1";
            this.etkDiliErrLab.Visible = false;
            // 
            // etkinlikKonusmacilariErrLab
            // 
            this.etkinlikKonusmacilariErrLab.AutoSize = true;
            this.etkinlikKonusmacilariErrLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etkinlikKonusmacilariErrLab.ForeColor = System.Drawing.Color.Crimson;
            this.etkinlikKonusmacilariErrLab.Location = new System.Drawing.Point(17, 437);
            this.etkinlikKonusmacilariErrLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etkinlikKonusmacilariErrLab.Name = "etkinlikKonusmacilariErrLab";
            this.etkinlikKonusmacilariErrLab.Size = new System.Drawing.Size(35, 13);
            this.etkinlikKonusmacilariErrLab.TabIndex = 7;
            this.etkinlikKonusmacilariErrLab.Text = "label1";
            this.etkinlikKonusmacilariErrLab.Visible = false;
            // 
            // etkYonBilgiAlanlariErrLab
            // 
            this.etkYonBilgiAlanlariErrLab.AutoSize = true;
            this.etkYonBilgiAlanlariErrLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etkYonBilgiAlanlariErrLab.ForeColor = System.Drawing.Color.Crimson;
            this.etkYonBilgiAlanlariErrLab.Location = new System.Drawing.Point(249, 440);
            this.etkYonBilgiAlanlariErrLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etkYonBilgiAlanlariErrLab.Name = "etkYonBilgiAlanlariErrLab";
            this.etkYonBilgiAlanlariErrLab.Size = new System.Drawing.Size(35, 13);
            this.etkYonBilgiAlanlariErrLab.TabIndex = 7;
            this.etkYonBilgiAlanlariErrLab.Text = "label1";
            this.etkYonBilgiAlanlariErrLab.Visible = false;
            // 
            // EkleBut
            // 
            this.EkleBut.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.EkleBut.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.EkleBut.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.EkleBut.BorderRadius = 15;
            this.EkleBut.BorderSize = 0;
            this.EkleBut.FlatAppearance.BorderSize = 0;
            this.EkleBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EkleBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EkleBut.ForeColor = System.Drawing.Color.White;
            this.EkleBut.Location = new System.Drawing.Point(561, 562);
            this.EkleBut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EkleBut.Name = "EkleBut";
            this.EkleBut.Size = new System.Drawing.Size(90, 29);
            this.EkleBut.TabIndex = 9;
            this.EkleBut.Text = "Ekle";
            this.EkleBut.TextColor = System.Drawing.Color.White;
            this.EkleBut.UseVisualStyleBackColor = false;
            this.EkleBut.Click += new System.EventHandler(this.EkleBut_Click_1);
            // 
            // İptal
            // 
            this.İptal.BackColor = System.Drawing.Color.Crimson;
            this.İptal.BackgroundColor = System.Drawing.Color.Crimson;
            this.İptal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.İptal.BorderRadius = 15;
            this.İptal.BorderSize = 0;
            this.İptal.FlatAppearance.BorderSize = 0;
            this.İptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.İptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.İptal.ForeColor = System.Drawing.Color.White;
            this.İptal.Location = new System.Drawing.Point(653, 562);
            this.İptal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.İptal.Name = "İptal";
            this.İptal.Size = new System.Drawing.Size(90, 29);
            this.İptal.TabIndex = 9;
            this.İptal.Text = "İptal Et";
            this.İptal.TextColor = System.Drawing.Color.White;
            this.İptal.UseVisualStyleBackColor = false;
            this.İptal.Click += new System.EventHandler(this.İptal_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(19, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(181, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etkinliğin Konuşmacıları";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(250, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(1);
            this.label2.Size = new System.Drawing.Size(210, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Etkinliğin Yönelik Bilgi Alanları";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Myanmar Text", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(72)))));
            this.userName.Location = new System.Drawing.Point(99, 63);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(128, 62);
            this.userName.TabIndex = 11;
            this.userName.Text = "Fuarix";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::WindowsFormsApp2.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(25, 63);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(78, 87);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(111, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "VTYS - LAB - FUAR - PROJESİ";
            // 
            // userProfession
            // 
            this.userProfession.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userProfession.ForeColor = System.Drawing.Color.DimGray;
            this.userProfession.Location = new System.Drawing.Point(110, 114);
            this.userProfession.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userProfession.Name = "userProfession";
            this.userProfession.Size = new System.Drawing.Size(120, 34);
            this.userProfession.TabIndex = 12;
            this.userProfession.Text = "Kocaeli Üniversitesi   BSM- Bahar2022";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(25, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(1);
            this.label4.Size = new System.Drawing.Size(223, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Etkinlik işlemleri";
            // 
            // salonCB
            // 
            this.salonCB.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salonCB.FormattingEnabled = true;
            this.salonCB.Location = new System.Drawing.Point(590, 405);
            this.salonCB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.salonCB.Name = "salonCB";
            this.salonCB.Size = new System.Drawing.Size(150, 24);
            this.salonCB.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(525, 406);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(1);
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Salon";
            // 
            // salonCBErrLab
            // 
            this.salonCBErrLab.AutoSize = true;
            this.salonCBErrLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salonCBErrLab.ForeColor = System.Drawing.Color.Crimson;
            this.salonCBErrLab.Location = new System.Drawing.Point(587, 432);
            this.salonCBErrLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salonCBErrLab.Name = "salonCBErrLab";
            this.salonCBErrLab.Size = new System.Drawing.Size(35, 13);
            this.salonCBErrLab.TabIndex = 7;
            this.salonCBErrLab.Text = "label1";
            this.salonCBErrLab.Visible = false;
            // 
            // canliBaglati
            // 
            this.canliBaglati.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canliBaglati.Location = new System.Drawing.Point(140, 254);
            this.canliBaglati.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.canliBaglati.Name = "canliBaglati";
            this.canliBaglati.Size = new System.Drawing.Size(233, 22);
            this.canliBaglati.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(22, 255);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(1);
            this.label8.Size = new System.Drawing.Size(110, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Canlı Bağlantı";
            // 
            // canliBaglatiErrLab
            // 
            this.canliBaglatiErrLab.AutoSize = true;
            this.canliBaglatiErrLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canliBaglatiErrLab.ForeColor = System.Drawing.Color.Crimson;
            this.canliBaglatiErrLab.Location = new System.Drawing.Point(20, 279);
            this.canliBaglatiErrLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.canliBaglatiErrLab.Name = "canliBaglatiErrLab";
            this.canliBaglatiErrLab.Size = new System.Drawing.Size(35, 13);
            this.canliBaglatiErrLab.TabIndex = 7;
            this.canliBaglatiErrLab.Text = "label1";
            this.canliBaglatiErrLab.Visible = false;
            // 
            // ozet
            // 
            this.ozet.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ozet.Location = new System.Drawing.Point(21, 488);
            this.ozet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ozet.Multiline = true;
            this.ozet.Name = "ozet";
            this.ozet.Size = new System.Drawing.Size(722, 66);
            this.ozet.TabIndex = 0;
            // 
            // aaa
            // 
            this.aaa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.aaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.aaa.Location = new System.Drawing.Point(21, 462);
            this.aaa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aaa.Name = "aaa";
            this.aaa.Padding = new System.Windows.Forms.Padding(1);
            this.aaa.Size = new System.Drawing.Size(140, 20);
            this.aaa.TabIndex = 1;
            this.aaa.Text = "Özet";
            // 
            // ozetErrLab
            // 
            this.ozetErrLab.AutoSize = true;
            this.ozetErrLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ozetErrLab.ForeColor = System.Drawing.Color.Crimson;
            this.ozetErrLab.Location = new System.Drawing.Point(22, 557);
            this.ozetErrLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ozetErrLab.Name = "ozetErrLab";
            this.ozetErrLab.Size = new System.Drawing.Size(58, 13);
            this.ozetErrLab.TabIndex = 7;
            this.ozetErrLab.Text = "ozetErrLab";
            this.ozetErrLab.Visible = false;
            // 
            // arkaPlan
            // 
            this.arkaPlan.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arkaPlan.Location = new System.Drawing.Point(507, 255);
            this.arkaPlan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.arkaPlan.Name = "arkaPlan";
            this.arkaPlan.Size = new System.Drawing.Size(233, 22);
            this.arkaPlan.TabIndex = 0;
            // 
            // arkaPlanLink
            // 
            this.arkaPlanLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.arkaPlanLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arkaPlanLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.arkaPlanLink.Location = new System.Drawing.Point(390, 256);
            this.arkaPlanLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arkaPlanLink.Name = "arkaPlanLink";
            this.arkaPlanLink.Padding = new System.Windows.Forms.Padding(1);
            this.arkaPlanLink.Size = new System.Drawing.Size(110, 19);
            this.arkaPlanLink.TabIndex = 1;
            this.arkaPlanLink.Text = "Arka Plan Linki";
            // 
            // arkaPlanLinkErrLab
            // 
            this.arkaPlanLinkErrLab.AutoSize = true;
            this.arkaPlanLinkErrLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arkaPlanLinkErrLab.ForeColor = System.Drawing.Color.Crimson;
            this.arkaPlanLinkErrLab.Location = new System.Drawing.Point(388, 280);
            this.arkaPlanLinkErrLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arkaPlanLinkErrLab.Name = "arkaPlanLinkErrLab";
            this.arkaPlanLinkErrLab.Size = new System.Drawing.Size(35, 13);
            this.arkaPlanLinkErrLab.TabIndex = 7;
            this.arkaPlanLinkErrLab.Text = "label1";
            this.arkaPlanLinkErrLab.Visible = false;
            // 
            // baslangicSaat
            // 
            this.baslangicSaat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.baslangicSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslangicSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.baslangicSaat.Location = new System.Drawing.Point(525, 131);
            this.baslangicSaat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baslangicSaat.Name = "baslangicSaat";
            this.baslangicSaat.Padding = new System.Windows.Forms.Padding(1);
            this.baslangicSaat.Size = new System.Drawing.Size(130, 19);
            this.baslangicSaat.TabIndex = 1;
            this.baslangicSaat.Text = "Baslangıç Saati";
            // 
            // bitisSaat
            // 
            this.bitisSaat.CustomFormat = "hh:mm:ss";
            this.bitisSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.bitisSaat.Location = new System.Drawing.Point(391, 203);
            this.bitisSaat.Name = "bitisSaat";
            this.bitisSaat.Size = new System.Drawing.Size(215, 21);
            this.bitisSaat.TabIndex = 14;
            // 
            // etk_baslangicSaat
            // 
            this.etk_baslangicSaat.CustomFormat = "hh:mm:ss";
            this.etk_baslangicSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.etk_baslangicSaat.Location = new System.Drawing.Point(525, 153);
            this.etk_baslangicSaat.Name = "etk_baslangicSaat";
            this.etk_baslangicSaat.Size = new System.Drawing.Size(198, 21);
            this.etk_baslangicSaat.TabIndex = 15;
            // 
            // tarih
            // 
            this.tarih.CustomFormat = "dd:MM:yyyy";
            this.tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih.Location = new System.Drawing.Point(294, 153);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(200, 21);
            this.tarih.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(294, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(1);
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Etkinlik Tarih";
            // 
            // EtkinlikEkleDuzeltPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(772, 598);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.etk_baslangicSaat);
            this.Controls.Add(this.bitisSaat);
            this.Controls.Add(this.userProfession);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.İptal);
            this.Controls.Add(this.EkleBut);
            this.Controls.Add(this.arkaPlanLinkErrLab);
            this.Controls.Add(this.canliBaglatiErrLab);
            this.Controls.Add(this.etkYonBilgiAlanlariErrLab);
            this.Controls.Add(this.etkinlikKonusmacilariErrLab);
            this.Controls.Add(this.ozetErrLab);
            this.Controls.Add(this.bitisSaatErrLab);
            this.Controls.Add(this.salonCBErrLab);
            this.Controls.Add(this.etkDiliErrLab);
            this.Controls.Add(this.baslangicSaatErrLab);
            this.Controls.Add(this.etkTuruErrLab);
            this.Controls.Add(this.tarihErrLab);
            this.Controls.Add(this.baslikErrLab);
            this.Controls.Add(this.etkinlikYonBilgiAlan);
            this.Controls.Add(this.etkinlikKonusmacilari);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.meslekL);
            this.Controls.Add(this.salonCB);
            this.Controls.Add(this.label);
            this.Controls.Add(this.etkDili);
            this.Controls.Add(this.etkTuru);
            this.Controls.Add(this.arkaPlanLink);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.eposta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.baslangicSaat);
            this.Controls.Add(this.arkaPlan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.canliBaglati);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.ozet);
            this.Controls.Add(this.baslik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EtkinlikEkleDuzeltPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etkinlik işlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox baslik;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label eposta;
        private System.Windows.Forms.ComboBox etkTuru;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox etkDili;
        private System.Windows.Forms.Label meslekL;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.CheckedListBox etkinlikKonusmacilari;
        private System.Windows.Forms.CheckedListBox etkinlikYonBilgiAlan;
        private System.Windows.Forms.Label baslikErrLab;
        private System.Windows.Forms.Label tarihErrLab;
        private System.Windows.Forms.Label bitisSaatErrLab;
        private System.Windows.Forms.Label baslangicSaatErrLab;
        private System.Windows.Forms.Label etkTuruErrLab;
        private System.Windows.Forms.Label etkDiliErrLab;
        private System.Windows.Forms.Label etkinlikKonusmacilariErrLab;
        private System.Windows.Forms.Label etkYonBilgiAlanlariErrLab;
        private RJButton EkleBut;
        private RJButton İptal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userProfession;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox salonCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label salonCBErrLab;
        private System.Windows.Forms.TextBox canliBaglati;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label canliBaglatiErrLab;
        private System.Windows.Forms.TextBox ozet;
        private System.Windows.Forms.Label aaa;
        private System.Windows.Forms.Label ozetErrLab;
        private System.Windows.Forms.TextBox arkaPlan;
        private System.Windows.Forms.Label arkaPlanLink;
        private System.Windows.Forms.Label arkaPlanLinkErrLab;
        private System.Windows.Forms.Label baslangicSaat;
        private System.Windows.Forms.DateTimePicker bitisSaat;
        private System.Windows.Forms.DateTimePicker etk_baslangicSaat;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Label label6;
    }
}