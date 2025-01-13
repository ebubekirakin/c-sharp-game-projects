namespace mayınTarlası
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMayinTarlasi = new Panel();
            btnBaslat = new Button();
            txtMayinSayisi = new TextBox();
            lblDurum = new Label();
            SuspendLayout();
            // 
            // pnlMayinTarlasi
            // 
            pnlMayinTarlasi.Location = new Point(491, 199);
            pnlMayinTarlasi.Name = "pnlMayinTarlasi";
            pnlMayinTarlasi.Size = new Size(250, 125);
            pnlMayinTarlasi.TabIndex = 0;
            pnlMayinTarlasi.Click += Btn_Click;
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(94, 321);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(167, 65);
            btnBaslat.TabIndex = 1;
            btnBaslat.Tag = "0";
            btnBaslat.Text = "BAŞLAT";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // txtMayinSayisi
            // 
            txtMayinSayisi.Location = new Point(58, 85);
            txtMayinSayisi.Name = "txtMayinSayisi";
            txtMayinSayisi.PlaceholderText = "Mayın Sayısı";
            txtMayinSayisi.Size = new Size(173, 27);
            txtMayinSayisi.TabIndex = 2;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(568, 75);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(116, 20);
            lblDurum.TabIndex = 3;
            lblDurum.Text = "Oyun Başlamadı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDurum);
            Controls.Add(txtMayinSayisi);
            Controls.Add(btnBaslat);
            Controls.Add(pnlMayinTarlasi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMayinTarlasi;
        private Button btnBaslat;
        private TextBox txtMayinSayisi;
        private Label lblDurum;
    }
}
