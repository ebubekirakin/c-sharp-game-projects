namespace arabaYarisi
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbTrafik1 = new PictureBox();
            pbOyuncuAraba = new PictureBox();
            pbTrafik3 = new PictureBox();
            pbTrafik2 = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            lblSkor = new Label();
            ((System.ComponentModel.ISupportInitialize)pbTrafik1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOyuncuAraba).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTrafik3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTrafik2).BeginInit();
            SuspendLayout();
            // 
            // pbTrafik1
            // 
            pbTrafik1.BackgroundImage = (Image)resources.GetObject("pbTrafik1.BackgroundImage");
            pbTrafik1.BackgroundImageLayout = ImageLayout.Stretch;
            pbTrafik1.Location = new Point(428, 134);
            pbTrafik1.Name = "pbTrafik1";
            pbTrafik1.Size = new Size(50, 100);
            pbTrafik1.TabIndex = 0;
            pbTrafik1.TabStop = false;
            // 
            // pbOyuncuAraba
            // 
            pbOyuncuAraba.BackgroundImage = (Image)resources.GetObject("pbOyuncuAraba.BackgroundImage");
            pbOyuncuAraba.BackgroundImageLayout = ImageLayout.Stretch;
            pbOyuncuAraba.ErrorImage = null;
            pbOyuncuAraba.Location = new Point(372, 328);
            pbOyuncuAraba.Name = "pbOyuncuAraba";
            pbOyuncuAraba.Size = new Size(50, 100);
            pbOyuncuAraba.TabIndex = 1;
            pbOyuncuAraba.TabStop = false;
            // 
            // pbTrafik3
            // 
            pbTrafik3.BackgroundImage = (Image)resources.GetObject("pbTrafik3.BackgroundImage");
            pbTrafik3.BackgroundImageLayout = ImageLayout.Stretch;
            pbTrafik3.Location = new Point(129, 65);
            pbTrafik3.Name = "pbTrafik3";
            pbTrafik3.Size = new Size(50, 100);
            pbTrafik3.TabIndex = 2;
            pbTrafik3.TabStop = false;
            // 
            // pbTrafik2
            // 
            pbTrafik2.BackgroundImage = (Image)resources.GetObject("pbTrafik2.BackgroundImage");
            pbTrafik2.BackgroundImageLayout = ImageLayout.Stretch;
            pbTrafik2.Location = new Point(645, 65);
            pbTrafik2.Name = "pbTrafik2";
            pbTrafik2.Size = new Size(50, 100);
            pbTrafik2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTrafik2.TabIndex = 3;
            pbTrafik2.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // lblSkor
            // 
            lblSkor.AutoSize = true;
            lblSkor.Location = new Point(707, 19);
            lblSkor.Name = "lblSkor";
            lblSkor.Size = new Size(38, 20);
            lblSkor.TabIndex = 4;
            lblSkor.Text = "Skor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSkor);
            Controls.Add(pbTrafik2);
            Controls.Add(pbTrafik3);
            Controls.Add(pbOyuncuAraba);
            Controls.Add(pbTrafik1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbTrafik1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOyuncuAraba).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTrafik3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTrafik2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbTrafik1;
        private PictureBox pbOyuncuAraba;
        private PictureBox pbTrafik3;
        private PictureBox pbTrafik2;
        private System.Windows.Forms.Timer gameTimer;
        private Label lblSkor;
    }
}
