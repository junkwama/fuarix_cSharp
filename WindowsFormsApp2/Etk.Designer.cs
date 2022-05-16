namespace WindowsFormsApp2
{
    partial class Etk
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
            this.anaPaneli = new System.Windows.Forms.Panel();
            this.etkinlikDetaylariPaneli = new System.Windows.Forms.Panel();
            this.konuPaneli = new System.Windows.Forms.Panel();
            this.tarihPaneli = new System.Windows.Forms.Panel();
            this.etkinlikTarih = new System.Windows.Forms.Label();
            this.adPaneli = new System.Windows.Forms.Panel();
            this.konusmaciAdi = new System.Windows.Forms.Label();
            this.etkinlikArkaPlanPic = new System.Windows.Forms.PictureBox();
            this.etkinlikKonusu = new System.Windows.Forms.Label();
            this.anaPaneli.SuspendLayout();
            this.etkinlikDetaylariPaneli.SuspendLayout();
            this.tarihPaneli.SuspendLayout();
            this.adPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etkinlikArkaPlanPic)).BeginInit();
            this.SuspendLayout();
            // 
            // anaPaneli
            // 
            this.anaPaneli.Controls.Add(this.etkinlikDetaylariPaneli);
            this.anaPaneli.Controls.Add(this.etkinlikArkaPlanPic);
            this.anaPaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anaPaneli.Location = new System.Drawing.Point(0, 0);
            this.anaPaneli.Name = "anaPaneli";
            this.anaPaneli.Padding = new System.Windows.Forms.Padding(5);
            this.anaPaneli.Size = new System.Drawing.Size(247, 320);
            this.anaPaneli.TabIndex = 0;
            // 
            // etkinlikDetaylariPaneli
            // 
            this.etkinlikDetaylariPaneli.Controls.Add(this.konuPaneli);
            this.etkinlikDetaylariPaneli.Controls.Add(this.tarihPaneli);
            this.etkinlikDetaylariPaneli.Controls.Add(this.adPaneli);
            this.etkinlikDetaylariPaneli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.etkinlikDetaylariPaneli.Location = new System.Drawing.Point(5, 172);
            this.etkinlikDetaylariPaneli.Name = "etkinlikDetaylariPaneli";
            this.etkinlikDetaylariPaneli.Size = new System.Drawing.Size(237, 143);
            this.etkinlikDetaylariPaneli.TabIndex = 1;
            // 
            // konuPaneli
            // 
            this.konuPaneli.Location = new System.Drawing.Point(3, 34);
            this.konuPaneli.Name = "konuPaneli";
            this.konuPaneli.Size = new System.Drawing.Size(200, 69);
            this.konuPaneli.TabIndex = 0;
            // 
            // tarihPaneli
            // 
            this.tarihPaneli.Controls.Add(this.etkinlikTarih);
            this.tarihPaneli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tarihPaneli.Location = new System.Drawing.Point(0, 117);
            this.tarihPaneli.Name = "tarihPaneli";
            this.tarihPaneli.Size = new System.Drawing.Size(237, 26);
            this.tarihPaneli.TabIndex = 1;
            // 
            // etkinlikTarih
            // 
            this.etkinlikTarih.AutoSize = true;
            this.etkinlikTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etkinlikTarih.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.etkinlikTarih.Location = new System.Drawing.Point(136, 10);
            this.etkinlikTarih.Name = "etkinlikTarih";
            this.etkinlikTarih.Size = new System.Drawing.Size(98, 13);
            this.etkinlikTarih.TabIndex = 0;
            this.etkinlikTarih.Text = "12/12/2022  18:45";
            // 
            // adPaneli
            // 
            this.adPaneli.Controls.Add(this.konusmaciAdi);
            this.adPaneli.Dock = System.Windows.Forms.DockStyle.Top;
            this.adPaneli.Location = new System.Drawing.Point(0, 0);
            this.adPaneli.Name = "adPaneli";
            this.adPaneli.Size = new System.Drawing.Size(237, 28);
            this.adPaneli.TabIndex = 1;
            // 
            // konusmaciAdi
            // 
            this.konusmaciAdi.AutoSize = true;
            this.konusmaciAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.konusmaciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konusmaciAdi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.konusmaciAdi.Location = new System.Drawing.Point(0, 0);
            this.konusmaciAdi.Name = "konusmaciAdi";
            this.konusmaciAdi.Size = new System.Drawing.Size(71, 18);
            this.konusmaciAdi.TabIndex = 0;
            this.konusmaciAdi.Text = "Ad Soyad";
            // 
            // etkinlikArkaPlanPic
            // 
            this.etkinlikArkaPlanPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.etkinlikArkaPlanPic.Image = global::WindowsFormsApp2.Properties.Resources.etkinlikVarsayilanBg2;
            this.etkinlikArkaPlanPic.Location = new System.Drawing.Point(5, 5);
            this.etkinlikArkaPlanPic.Name = "etkinlikArkaPlanPic";
            this.etkinlikArkaPlanPic.Size = new System.Drawing.Size(237, 164);
            this.etkinlikArkaPlanPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.etkinlikArkaPlanPic.TabIndex = 0;
            this.etkinlikArkaPlanPic.TabStop = false;
            // 
            // etkinlikKonusu
            // 
            this.etkinlikKonusu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.etkinlikKonusu.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etkinlikKonusu.ForeColor = System.Drawing.Color.Black;
            this.etkinlikKonusu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.etkinlikKonusu.Location = new System.Drawing.Point(0, 0);
            this.etkinlikKonusu.Name = "etkinlikKonusu";
            this.etkinlikKonusu.Size = new System.Drawing.Size(135, 19);
            this.etkinlikKonusu.TabIndex = 0;
            this.etkinlikKonusu.Text = "Etkinlik Konusu";
            // 
            // Etk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.anaPaneli);
            this.Name = "Etk";
            this.Size = new System.Drawing.Size(247, 320);
            this.anaPaneli.ResumeLayout(false);
            this.etkinlikDetaylariPaneli.ResumeLayout(false);
            this.tarihPaneli.ResumeLayout(false);
            this.tarihPaneli.PerformLayout();
            this.adPaneli.ResumeLayout(false);
            this.adPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etkinlikArkaPlanPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel anaPaneli;
        private System.Windows.Forms.Panel etkinlikDetaylariPaneli;
        private System.Windows.Forms.Panel konuPaneli;
        private System.Windows.Forms.Label etkinlikKonusu;
        private System.Windows.Forms.Panel tarihPaneli;
        private System.Windows.Forms.Label etkinlikTarih;
        private System.Windows.Forms.Panel adPaneli;
        private System.Windows.Forms.Label konusmaciAdi;
        private System.Windows.Forms.PictureBox etkinlikArkaPlanPic;
    }
}
