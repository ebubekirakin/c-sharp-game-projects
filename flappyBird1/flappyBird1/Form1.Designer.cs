namespace flappyBird1
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
            flappyBird = new PictureBox();
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ground = new PictureBox();
            startGame = new Button();
            jumpButton = new Button();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // flappyBird
            // 
            flappyBird.Image = (Image)resources.GetObject("flappyBird.Image");
            flappyBird.Location = new Point(372, 218);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(35, 27);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 0;
            flappyBird.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.Image = (Image)resources.GetObject("pipeTop.Image");
            pipeTop.Location = new Point(364, -2);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(60, 200);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 1;
            pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = (Image)resources.GetObject("pipeBottom.Image");
            pipeBottom.Location = new Point(364, 296);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(60, 200);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = SystemColors.ActiveCaption;
            scoreText.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreText.Location = new Point(508, 9);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(67, 24);
            scoreText.TabIndex = 3;
            scoreText.Text = "skor";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            // 
            // ground
            // 
            ground.Image = (Image)resources.GetObject("ground.Image");
            ground.Location = new Point(1, 492);
            ground.Name = "ground";
            ground.Size = new Size(780, 62);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 4;
            ground.TabStop = false;
            // 
            // startGame
            // 
            startGame.Location = new Point(12, 432);
            startGame.Name = "startGame";
            startGame.Size = new Size(145, 43);
            startGame.TabIndex = 5;
            startGame.Text = "başla";
            startGame.UseVisualStyleBackColor = true;
            startGame.Click += startGame_Click;
            // 
            // jumpButton
            // 
            jumpButton.BackColor = Color.LightCoral;
            jumpButton.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jumpButton.Location = new Point(654, 338);
            jumpButton.Name = "jumpButton";
            jumpButton.Size = new Size(94, 51);
            jumpButton.TabIndex = 6;
            jumpButton.Text = "zıpla";
            jumpButton.UseVisualStyleBackColor = false;
            jumpButton.Click += jumpButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(782, 553);
            Controls.Add(jumpButton);
            Controls.Add(startGame);
            Controls.Add(ground);
            Controls.Add(scoreText);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Controls.Add(flappyBird);
            DoubleBuffered = true;
            HelpButton = true;
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox flappyBird;
        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox ground;
        private Button startGame;
        private Button jumpButton;
    }
}
