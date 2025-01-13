namespace adamasmaca_1
{
    partial class AdamAsmaca
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
            labelAttempts = new Label();
            labelWord = new Label();
            textBoxGuess = new TextBox();
            pictureBoxHangman = new PictureBox();
            buttonGuess = new Button();
            labelHarf = new Label();
            lblWrongWord = new Label();
            harfler = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHangman).BeginInit();
            SuspendLayout();
            // 
            // labelAttempts
            // 
            labelAttempts.AutoSize = true;
            labelAttempts.BackColor = Color.IndianRed;
            labelAttempts.Location = new Point(54, 68);
            labelAttempts.Margin = new Padding(5, 0, 5, 0);
            labelAttempts.Name = "labelAttempts";
            labelAttempts.Size = new Size(76, 24);
            labelAttempts.TabIndex = 0;
            labelAttempts.Text = "Haklar";
            // 
            // labelWord
            // 
            labelWord.AutoSize = true;
            labelWord.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWord.Location = new Point(918, 490);
            labelWord.Margin = new Padding(5, 0, 5, 0);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(0, 35);
            labelWord.TabIndex = 1;
            // 
            // textBoxGuess
            // 
            textBoxGuess.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBoxGuess.Location = new Point(54, 243);
            textBoxGuess.Margin = new Padding(5, 4, 5, 4);
            textBoxGuess.MaxLength = 1;
            textBoxGuess.Name = "textBoxGuess";
            textBoxGuess.Size = new Size(290, 40);
            textBoxGuess.TabIndex = 2;
            // 
            // pictureBoxHangman
            // 
            pictureBoxHangman.Location = new Point(650, 10);
            pictureBoxHangman.Margin = new Padding(5, 4, 5, 4);
            pictureBoxHangman.Name = "pictureBoxHangman";
            pictureBoxHangman.Size = new Size(627, 447);
            pictureBoxHangman.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHangman.TabIndex = 3;
            pictureBoxHangman.TabStop = false;
            // 
            // buttonGuess
            // 
            buttonGuess.BackColor = SystemColors.Info;
            buttonGuess.Location = new Point(112, 378);
            buttonGuess.Margin = new Padding(5, 4, 5, 4);
            buttonGuess.Name = "buttonGuess";
            buttonGuess.Size = new Size(153, 35);
            buttonGuess.TabIndex = 4;
            buttonGuess.Text = "Tahmin Et";
            buttonGuess.UseVisualStyleBackColor = false;
            buttonGuess.Click += buttonGuess_Click;
            // 
            // labelHarf
            // 
            labelHarf.AutoSize = true;
            labelHarf.BackColor = Color.IndianRed;
            labelHarf.Location = new Point(136, 194);
            labelHarf.Margin = new Padding(5, 0, 5, 0);
            labelHarf.Name = "labelHarf";
            labelHarf.Size = new Size(109, 24);
            labelHarf.TabIndex = 5;
            labelHarf.Text = "Harf Girin";
            // 
            // lblWrongWord
            // 
            lblWrongWord.AutoSize = true;
            lblWrongWord.BackColor = Color.Red;
            lblWrongWord.Location = new Point(136, 311);
            lblWrongWord.Name = "lblWrongWord";
            lblWrongWord.Size = new Size(72, 24);
            lblWrongWord.TabIndex = 6;
            lblWrongWord.Text = "label1";
            // 
            // harfler
            // 
            harfler.AutoSize = true;
            harfler.BackColor = Color.IndianRed;
            harfler.Location = new Point(345, 311);
            harfler.Name = "harfler";
            harfler.Size = new Size(143, 24);
            harfler.TabIndex = 7;
            harfler.Text = "Çıkan Harfler";
            // 
            // AdamAsmaca
            // 
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1319, 575);
            Controls.Add(harfler);
            Controls.Add(lblWrongWord);
            Controls.Add(labelHarf);
            Controls.Add(buttonGuess);
            Controls.Add(pictureBoxHangman);
            Controls.Add(textBoxGuess);
            Controls.Add(labelWord);
            Controls.Add(labelAttempts);
            Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "AdamAsmaca";
            Text = "AdamAsmaca";
            ((System.ComponentModel.ISupportInitialize)pictureBoxHangman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAttempts;
        private Label labelWord;
        private TextBox textBoxGuess;
        private PictureBox pictureBoxHangman;
        private Button buttonGuess;
        private Label labelHarf;
        private Label lblWrongWord;
        private Label harfler;
    }
}
