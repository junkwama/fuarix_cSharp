namespace WindowsFormsApp2
{
    partial class UyelerForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.banerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.uyelerFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.uyeEkle = new WindowsFormsApp2.RJButton();
            this.banerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(715, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // banerPanel
            // 
            this.banerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(82)))), ((int)(((byte)(137)))));
            this.banerPanel.Controls.Add(this.label1);
            this.banerPanel.Location = new System.Drawing.Point(12, -2);
            this.banerPanel.Name = "banerPanel";
            this.banerPanel.Size = new System.Drawing.Size(711, 33);
            this.banerPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(234)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üyeler";
            // 
            // uyelerFlowPanel
            // 
            this.uyelerFlowPanel.AutoScroll = true;
            this.uyelerFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.uyelerFlowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uyelerFlowPanel.Location = new System.Drawing.Point(0, 77);
            this.uyelerFlowPanel.Name = "uyelerFlowPanel";
            this.uyelerFlowPanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.uyelerFlowPanel.Size = new System.Drawing.Size(760, 543);
            this.uyelerFlowPanel.TabIndex = 17;
            // 
            // uyeEkle
            // 
            this.uyeEkle.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.uyeEkle.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.uyeEkle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.uyeEkle.BorderRadius = 18;
            this.uyeEkle.BorderSize = 0;
            this.uyeEkle.FlatAppearance.BorderSize = 0;
            this.uyeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uyeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeEkle.ForeColor = System.Drawing.Color.White;
            this.uyeEkle.Location = new System.Drawing.Point(691, 35);
            this.uyeEkle.Name = "uyeEkle";
            this.uyeEkle.Size = new System.Drawing.Size(60, 36);
            this.uyeEkle.TabIndex = 18;
            this.uyeEkle.Text = "Ekle";
            this.uyeEkle.TextColor = System.Drawing.Color.White;
            this.uyeEkle.UseVisualStyleBackColor = false;
            this.uyeEkle.Click += new System.EventHandler(this.uyeEkle_Click);
            // 
            // UyelerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(760, 620);
            this.Controls.Add(this.uyeEkle);
            this.Controls.Add(this.uyelerFlowPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.banerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "UyelerForm";
            this.Text = "Üyeler";
            this.Load += new System.EventHandler(this.UyelerForm_Load);
            this.banerPanel.ResumeLayout(false);
            this.banerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel banerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel uyelerFlowPanel;
        private RJButton uyeEkle;
    }
}