namespace WindowsFormsApp2
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yoneticiBilgileriLab = new System.Windows.Forms.Label();
            this.biletlerBut = new System.Windows.Forms.Button();
            this.konusmacilarBut = new System.Windows.Forms.Button();
            this.salonlarBut = new System.Windows.Forms.Button();
            this.uyelerBut = new System.Windows.Forms.Button();
            this.etkinliklerBut = new System.Windows.Forms.Button();
            this.kontrolPaneliBut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userProfession = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.anaBolgePaneli = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(82)))), ((int)(((byte)(137)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.biletlerBut);
            this.panel1.Controls.Add(this.konusmacilarBut);
            this.panel1.Controls.Add(this.salonlarBut);
            this.panel1.Controls.Add(this.uyelerBut);
            this.panel1.Controls.Add(this.etkinliklerBut);
            this.panel1.Controls.Add(this.kontrolPaneliBut);
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.yoneticiBilgileriLab);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel3.Name = "panel3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.icone2;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // yoneticiBilgileriLab
            // 
            resources.ApplyResources(this.yoneticiBilgileriLab, "yoneticiBilgileriLab");
            this.yoneticiBilgileriLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.yoneticiBilgileriLab.Name = "yoneticiBilgileriLab";
            // 
            // biletlerBut
            // 
            this.biletlerBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(185)))), ((int)(((byte)(249)))));
            this.biletlerBut.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.biletlerBut, "biletlerBut");
            this.biletlerBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.biletlerBut.Image = global::WindowsFormsApp2.Properties.Resources.biletler;
            this.biletlerBut.Name = "biletlerBut";
            this.biletlerBut.UseVisualStyleBackColor = false;
            this.biletlerBut.Click += new System.EventHandler(this.biletlerBut_Click);
            this.biletlerBut.Enter += new System.EventHandler(this.biletlerBut_Focus);
            // 
            // konusmacilarBut
            // 
            this.konusmacilarBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(185)))), ((int)(((byte)(249)))));
            this.konusmacilarBut.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.konusmacilarBut, "konusmacilarBut");
            this.konusmacilarBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.konusmacilarBut.Image = global::WindowsFormsApp2.Properties.Resources.uyeee;
            this.konusmacilarBut.Name = "konusmacilarBut";
            this.konusmacilarBut.UseVisualStyleBackColor = false;
            this.konusmacilarBut.Click += new System.EventHandler(this.konusmacilarBut_Click);
            this.konusmacilarBut.Enter += new System.EventHandler(this.konusmacilarBut_Focus);
            // 
            // salonlarBut
            // 
            this.salonlarBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(185)))), ((int)(((byte)(249)))));
            this.salonlarBut.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.salonlarBut, "salonlarBut");
            this.salonlarBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.salonlarBut.Image = global::WindowsFormsApp2.Properties.Resources.krlPanel;
            this.salonlarBut.Name = "salonlarBut";
            this.salonlarBut.UseVisualStyleBackColor = false;
            this.salonlarBut.Click += new System.EventHandler(this.salonlarBut_Click);
            this.salonlarBut.Enter += new System.EventHandler(this.salonlarBut_Focus);
            // 
            // uyelerBut
            // 
            this.uyelerBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(185)))), ((int)(((byte)(249)))));
            this.uyelerBut.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.uyelerBut, "uyelerBut");
            this.uyelerBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.uyelerBut.Image = global::WindowsFormsApp2.Properties.Resources.uye;
            this.uyelerBut.Name = "uyelerBut";
            this.uyelerBut.UseVisualStyleBackColor = false;
            this.uyelerBut.Click += new System.EventHandler(this.uyelerBut_Click);
            this.uyelerBut.Enter += new System.EventHandler(this.uyelerBut_Focus);
            // 
            // etkinliklerBut
            // 
            this.etkinliklerBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(185)))), ((int)(((byte)(249)))));
            this.etkinliklerBut.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.etkinliklerBut, "etkinliklerBut");
            this.etkinliklerBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.etkinliklerBut.Image = global::WindowsFormsApp2.Properties.Resources.etklik;
            this.etkinliklerBut.Name = "etkinliklerBut";
            this.etkinliklerBut.UseVisualStyleBackColor = false;
            this.etkinliklerBut.Click += new System.EventHandler(this.etkinliklerBut_Click);
            this.etkinliklerBut.Enter += new System.EventHandler(this.etkinliklerBut_Focus);
            // 
            // kontrolPaneliBut
            // 
            this.kontrolPaneliBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(185)))), ((int)(((byte)(249)))));
            this.kontrolPaneliBut.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.kontrolPaneliBut, "kontrolPaneliBut");
            this.kontrolPaneliBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.kontrolPaneliBut.Image = global::WindowsFormsApp2.Properties.Resources.istats;
            this.kontrolPaneliBut.Name = "kontrolPaneliBut";
            this.kontrolPaneliBut.UseVisualStyleBackColor = false;
            this.kontrolPaneliBut.Click += new System.EventHandler(this.kontrolPaneliBut_Click);
            this.kontrolPaneliBut.Enter += new System.EventHandler(this.kontrolPaneliBut_Focus);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.userProfession);
            this.panel2.Controls.Add(this.userName);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.logo;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Name = "label1";
            // 
            // userProfession
            // 
            resources.ApplyResources(this.userProfession, "userProfession");
            this.userProfession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.userProfession.Name = "userProfession";
            // 
            // userName
            // 
            resources.ApplyResources(this.userName, "userName");
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.userName.Name = "userName";
            // 
            // anaBolgePaneli
            // 
            resources.ApplyResources(this.anaBolgePaneli, "anaBolgePaneli");
            this.anaBolgePaneli.Name = "anaBolgePaneli";
            // 
            // AnaForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.anaBolgePaneli);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaForm";
            this.Load += new System.EventHandler(this.KontrolPaneliForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userProfession;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button kontrolPaneliBut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label yoneticiBilgileriLab;
        private System.Windows.Forms.Panel anaBolgePaneli;
        private System.Windows.Forms.Button etkinliklerBut;
        private System.Windows.Forms.Button konusmacilarBut;
        private System.Windows.Forms.Button uyelerBut;
        private System.Windows.Forms.Button biletlerBut;
        private System.Windows.Forms.Button salonlarBut;
    }
}

