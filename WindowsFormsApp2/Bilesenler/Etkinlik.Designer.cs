namespace WindowsFormsApp2.Bilesenler
{
    partial class Etkinlik
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.etkTuruLab = new System.Windows.Forms.Label();
            this.konuLab = new System.Windows.Forms.Label();
            this.tarihLab = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = global::WindowsFormsApp2.Properties.Resources.etkinlikVarsayilanBg;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.etkinlikVarsayilanBg;
            this.pictureBox1.InitialImage = global::WindowsFormsApp2.Properties.Resources.etkinlikVarsayilanBg;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.etk_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.Etkinlik_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.Etkinlik_MouseLeave);
            // 
            // etkTuruLab
            // 
            this.etkTuruLab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.etkTuruLab.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.etkTuruLab.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etkTuruLab.ForeColor = System.Drawing.Color.White;
            this.etkTuruLab.Location = new System.Drawing.Point(2, 92);
            this.etkTuruLab.Name = "etkTuruLab";
            this.etkTuruLab.Size = new System.Drawing.Size(91, 18);
            this.etkTuruLab.TabIndex = 1;
            this.etkTuruLab.Text = "Etk Tütü";
            this.etkTuruLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.etkTuruLab.Click += new System.EventHandler(this.etk_Click);
            this.etkTuruLab.MouseEnter += new System.EventHandler(this.Etkinlik_MouseEnter);
            this.etkTuruLab.MouseLeave += new System.EventHandler(this.Etkinlik_MouseLeave);
            // 
            // konuLab
            // 
            this.konuLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.konuLab.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konuLab.ForeColor = System.Drawing.Color.Black;
            this.konuLab.Location = new System.Drawing.Point(0, 112);
            this.konuLab.Name = "konuLab";
            this.konuLab.Size = new System.Drawing.Size(163, 77);
            this.konuLab.TabIndex = 1;
            this.konuLab.Text = "Konu";
            this.konuLab.Click += new System.EventHandler(this.etk_Click);
            this.konuLab.MouseEnter += new System.EventHandler(this.Etkinlik_MouseEnter);
            this.konuLab.MouseLeave += new System.EventHandler(this.Etkinlik_MouseLeave);
            // 
            // tarihLab
            // 
            this.tarihLab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tarihLab.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarihLab.ForeColor = System.Drawing.Color.DimGray;
            this.tarihLab.Location = new System.Drawing.Point(2, 189);
            this.tarihLab.Name = "tarihLab";
            this.tarihLab.Size = new System.Drawing.Size(159, 14);
            this.tarihLab.TabIndex = 1;
            this.tarihLab.Text = "Tarih";
            this.tarihLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tarihLab.Click += new System.EventHandler(this.etk_Click);
            // 
            // edit
            // 
            this.edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(1, 68);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(61, 23);
            this.edit.TabIndex = 2;
            this.edit.Text = "Düzeltle";
            this.edit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Etkinlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.edit);
            this.Controls.Add(this.tarihLab);
            this.Controls.Add(this.konuLab);
            this.Controls.Add(this.etkTuruLab);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 10, 15);
            this.Name = "Etkinlik";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(163, 205);
            this.Load += new System.EventHandler(this.Etkinlik_Load);
            this.Click += new System.EventHandler(this.etk_Click);
            this.MouseEnter += new System.EventHandler(this.Etkinlik_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Etkinlik_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label etkTuruLab;
        private System.Windows.Forms.Label konuLab;
        private System.Windows.Forms.Label tarihLab;
        private System.Windows.Forms.Button edit;
    }
}
