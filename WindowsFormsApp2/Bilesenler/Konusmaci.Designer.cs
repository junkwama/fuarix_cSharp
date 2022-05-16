namespace WindowsFormsApp2.Bilesenler
{
    partial class Konusmaci
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.container = new System.Windows.Forms.Panel();
            this.aboutLab = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileLab = new System.Windows.Forms.PictureBox();
            this.detailsLab = new System.Windows.Forms.Label();
            this.adiLab = new System.Windows.Forms.Label();
            this.silBut = new WindowsFormsApp2.RJButton();
            this.gunceleBut = new WindowsFormsApp2.RJButton();
            this.siteLink = new System.Windows.Forms.LinkLabel();
            this.container.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileLab)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.DarkMagenta;
            this.container.Controls.Add(this.aboutLab);
            this.container.Controls.Add(this.panel1);
            this.container.Controls.Add(this.detailsLab);
            this.container.Controls.Add(this.adiLab);
            this.container.Location = new System.Drawing.Point(14, 9);
            this.container.Name = "container";
            this.container.Padding = new System.Windows.Forms.Padding(7);
            this.container.Size = new System.Drawing.Size(685, 202);
            this.container.TabIndex = 0;
            // 
            // aboutLab
            // 
            this.aboutLab.BackColor = System.Drawing.Color.Transparent;
            this.aboutLab.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLab.ForeColor = System.Drawing.Color.White;
            this.aboutLab.Location = new System.Drawing.Point(161, 43);
            this.aboutLab.Name = "aboutLab";
            this.aboutLab.Size = new System.Drawing.Size(515, 116);
            this.aboutLab.TabIndex = 8;
            this.aboutLab.Text = "ad";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.profileLab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(141, 188);
            this.panel1.TabIndex = 10;
            // 
            // profileLab
            // 
            this.profileLab.BackColor = System.Drawing.Color.DodgerBlue;
            this.profileLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileLab.ErrorImage = global::WindowsFormsApp2.Properties.Resources.konusmaci2;
            this.profileLab.Image = global::WindowsFormsApp2.Properties.Resources.konusmaci2;
            this.profileLab.InitialImage = global::WindowsFormsApp2.Properties.Resources.konusmaci2;
            this.profileLab.Location = new System.Drawing.Point(4, 4);
            this.profileLab.Name = "profileLab";
            this.profileLab.Size = new System.Drawing.Size(133, 180);
            this.profileLab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.profileLab.TabIndex = 1;
            this.profileLab.TabStop = false;
            // 
            // detailsLab
            // 
            this.detailsLab.BackColor = System.Drawing.Color.Transparent;
            this.detailsLab.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsLab.ForeColor = System.Drawing.Color.White;
            this.detailsLab.Location = new System.Drawing.Point(157, 164);
            this.detailsLab.Name = "detailsLab";
            this.detailsLab.Size = new System.Drawing.Size(519, 32);
            this.detailsLab.TabIndex = 7;
            this.detailsLab.Text = "ad";
            this.detailsLab.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // adiLab
            // 
            this.adiLab.BackColor = System.Drawing.Color.Transparent;
            this.adiLab.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adiLab.ForeColor = System.Drawing.Color.White;
            this.adiLab.Location = new System.Drawing.Point(157, 9);
            this.adiLab.Name = "adiLab";
            this.adiLab.Size = new System.Drawing.Size(519, 32);
            this.adiLab.TabIndex = 9;
            this.adiLab.Text = "ad";
            // 
            // silBut
            // 
            this.silBut.BackColor = System.Drawing.Color.Crimson;
            this.silBut.BackgroundColor = System.Drawing.Color.Crimson;
            this.silBut.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.silBut.BorderRadius = 10;
            this.silBut.BorderSize = 0;
            this.silBut.FlatAppearance.BorderSize = 0;
            this.silBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silBut.ForeColor = System.Drawing.Color.White;
            this.silBut.Location = new System.Drawing.Point(639, 218);
            this.silBut.Name = "silBut";
            this.silBut.Size = new System.Drawing.Size(57, 25);
            this.silBut.TabIndex = 1;
            this.silBut.Text = "Sil";
            this.silBut.TextColor = System.Drawing.Color.White;
            this.silBut.UseVisualStyleBackColor = false;
            this.silBut.Click += new System.EventHandler(this.silBut_Click);
            // 
            // gunceleBut
            // 
            this.gunceleBut.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.gunceleBut.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.gunceleBut.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.gunceleBut.BorderRadius = 10;
            this.gunceleBut.BorderSize = 0;
            this.gunceleBut.FlatAppearance.BorderSize = 0;
            this.gunceleBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gunceleBut.ForeColor = System.Drawing.Color.White;
            this.gunceleBut.Location = new System.Drawing.Point(568, 218);
            this.gunceleBut.Name = "gunceleBut";
            this.gunceleBut.Size = new System.Drawing.Size(66, 25);
            this.gunceleBut.TabIndex = 1;
            this.gunceleBut.Text = "Güncele";
            this.gunceleBut.TextColor = System.Drawing.Color.White;
            this.gunceleBut.UseVisualStyleBackColor = false;
            this.gunceleBut.Click += new System.EventHandler(this.gunceleBut_Click);
            // 
            // siteLink
            // 
            this.siteLink.ActiveLinkColor = System.Drawing.Color.White;
            this.siteLink.BackColor = System.Drawing.Color.White;
            this.siteLink.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteLink.LinkColor = System.Drawing.Color.Purple;
            this.siteLink.Location = new System.Drawing.Point(473, 218);
            this.siteLink.Name = "siteLink";
            this.siteLink.Size = new System.Drawing.Size(89, 24);
            this.siteLink.TabIndex = 2;
            this.siteLink.TabStop = true;
            this.siteLink.Text = "Fazla Bilgi";
            this.siteLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Konusmaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.siteLink);
            this.Controls.Add(this.gunceleBut);
            this.Controls.Add(this.silBut);
            this.Controls.Add(this.container);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Konusmaci";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(721, 248);
            this.Load += new System.EventHandler(this.Konusmaci_Load);
            this.container.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileLab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label aboutLab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox profileLab;
        private System.Windows.Forms.Label detailsLab;
        private System.Windows.Forms.Label adiLab;
        private RJButton silBut;
        private RJButton gunceleBut;
        private System.Windows.Forms.LinkLabel siteLink;
    }
}
