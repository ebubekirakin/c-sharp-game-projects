namespace xoxoyunuodev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cmbBoyutSecimi = new ComboBox();
            btnBasla = new Button();
            pnlOyunAlani = new Panel();
            lblOyuncu1 = new Label();
            txtOyuncu1 = new TextBox();
            lblOyuncu2 = new Label();
            txtOyuncu2 = new TextBox();
            lblSkorlar = new Label();
            lblSkorOyuncu1 = new Label();
            lblSkorOyuncu2 = new Label();
            SuspendLayout();
            // 
            // cmbBoyutSecimi
            // 
            cmbBoyutSecimi.FormattingEnabled = true;
            cmbBoyutSecimi.Location = new Point(110, 184);
            cmbBoyutSecimi.Name = "cmbBoyutSecimi";
            cmbBoyutSecimi.Size = new Size(175, 28);
            cmbBoyutSecimi.TabIndex = 0;
            // 
            // btnBasla
            // 
            btnBasla.BackColor = Color.LightCoral;
            btnBasla.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBasla.Location = new Point(83, 268);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(221, 73);
            btnBasla.TabIndex = 1;
            btnBasla.Text = "Başla";
            btnBasla.UseVisualStyleBackColor = false;
            btnBasla.Click += BtnBasla_Click;
            // 
            // pnlOyunAlani
            // 
            pnlOyunAlani.BackgroundImage = (Image)resources.GetObject("pnlOyunAlani.BackgroundImage");
            pnlOyunAlani.BackgroundImageLayout = ImageLayout.Stretch;
            pnlOyunAlani.Location = new Point(331, 112);
            pnlOyunAlani.Name = "pnlOyunAlani";
            pnlOyunAlani.Size = new Size(457, 326);
            pnlOyunAlani.TabIndex = 2;
            // 
            // lblOyuncu1
            // 
            lblOyuncu1.AutoSize = true;
            lblOyuncu1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOyuncu1.Location = new Point(61, 28);
            lblOyuncu1.Name = "lblOyuncu1";
            lblOyuncu1.Size = new Size(73, 20);
            lblOyuncu1.TabIndex = 3;
            lblOyuncu1.Text = "oyuncu 1";
            // 
            // txtOyuncu1
            // 
            txtOyuncu1.Location = new Point(22, 59);
            txtOyuncu1.Name = "txtOyuncu1";
            txtOyuncu1.Size = new Size(144, 27);
            txtOyuncu1.TabIndex = 4;
            // 
            // lblOyuncu2
            // 
            lblOyuncu2.AutoSize = true;
            lblOyuncu2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOyuncu2.Location = new Point(283, 24);
            lblOyuncu2.Name = "lblOyuncu2";
            lblOyuncu2.Size = new Size(73, 20);
            lblOyuncu2.TabIndex = 5;
            lblOyuncu2.Text = "oyuncu 2";
            // 
            // txtOyuncu2
            // 
            txtOyuncu2.Location = new Point(249, 58);
            txtOyuncu2.Name = "txtOyuncu2";
            txtOyuncu2.Size = new Size(142, 27);
            txtOyuncu2.TabIndex = 6;
            // 
            // lblSkorlar
            // 
            lblSkorlar.AutoSize = true;
            lblSkorlar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSkorlar.Location = new Point(148, 157);
            lblSkorlar.Name = "lblSkorlar";
            lblSkorlar.Size = new Size(104, 24);
            lblSkorlar.TabIndex = 7;
            lblSkorlar.Text = "Boyut Seçin";
            // 
            // lblSkorOyuncu1
            // 
            lblSkorOyuncu1.AutoSize = true;
            lblSkorOyuncu1.BackColor = SystemColors.ControlDarkDark;
            lblSkorOyuncu1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSkorOyuncu1.ForeColor = SystemColors.ButtonHighlight;
            lblSkorOyuncu1.Location = new Point(649, 24);
            lblSkorOyuncu1.Name = "lblSkorOyuncu1";
            lblSkorOyuncu1.Size = new Size(99, 28);
            lblSkorOyuncu1.TabIndex = 8;
            lblSkorOyuncu1.Text = "oyuncu 1";
            // 
            // lblSkorOyuncu2
            // 
            lblSkorOyuncu2.AutoSize = true;
            lblSkorOyuncu2.BackColor = SystemColors.ControlDarkDark;
            lblSkorOyuncu2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSkorOyuncu2.ForeColor = SystemColors.ButtonHighlight;
            lblSkorOyuncu2.Location = new Point(649, 58);
            lblSkorOyuncu2.Name = "lblSkorOyuncu2";
            lblSkorOyuncu2.Size = new Size(99, 28);
            lblSkorOyuncu2.TabIndex = 9;
            lblSkorOyuncu2.Text = "oyuncu 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(lblSkorOyuncu2);
            Controls.Add(lblSkorOyuncu1);
            Controls.Add(lblSkorlar);
            Controls.Add(txtOyuncu2);
            Controls.Add(lblOyuncu2);
            Controls.Add(txtOyuncu1);
            Controls.Add(lblOyuncu1);
            Controls.Add(pnlOyunAlani);
            Controls.Add(btnBasla);
            Controls.Add(cmbBoyutSecimi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBoyutSecimi;
        private Button btnBasla;
        private Panel pnlOyunAlani;
        private Label lblOyuncu1;
        private TextBox txtOyuncu1;
        private Label lblOyuncu2;
        private TextBox txtOyuncu2;
        private Label lblSkorlar;
        private Label lblSkorOyuncu1;
        private Label lblSkorOyuncu2;
    }
}
