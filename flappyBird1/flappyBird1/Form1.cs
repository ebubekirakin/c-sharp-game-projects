using System;
using System.Windows.Forms;

namespace flappyBird1


{
    public partial class Form1 : Form
    {
        int pipeSpeed = 10;                // Borularýn hareket hýzý
        double gravity = 0.8;              // Kuþun düþüþ hýzý
        double jumpSpeed = 12;             // Kuþun zýplama hýzý
        double velocity = 0;                // Kuþun mevcut hýzý
        int score = 0;                      // Skor
        const int pipeWidth = 60;           // Borularýn geniþliði
        const int minPipeHeight = 50;       // Minimum üst boru yüksekliði
        const int maxPipeHeight = 400;      // Maksimum üst boru yüksekliði
        const int minPipeGap = 100;         // Borular arasýndaki minimum boþluk
        const int maxPipeGap = 200;         // Borular arasýndaki maksimum boþluk
        const int groundHeight = 62;        // Zemin yüksekliði
        Random rand = new Random();         // Rastgele sayý üretici
        bool isJumping = false;             // Kuþun zýplayýp zýplamadýðýný kontrol etmek için

        public Form1()
        {
            InitializeComponent();

            gameTimer.Tick += new EventHandler(gameTimerEvent);
            gameTimer.Interval = 20;
            gameTimer.Enabled = false;

            startGame.Enabled = true; // Baþla butonunu aktif hale getir
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            score = 0;
            scoreText.Text = "Skor: 0";

            flappyBird.Top = 200; // Kuþun baþlangýç yüksekliði
            resetPipes(); // Borularý ayarla

            startGame.Enabled = false; // Baþla butonunu devre dýþý býrak
        }


        private void resetPipes()
        {
            // Rastgele boþluk ve üst boru yüksekliði belirle
            int pipeGap = rand.Next(minPipeGap, maxPipeGap);
            int topHeight = rand.Next(minPipeHeight, maxPipeHeight); // 50 ile 400 arasýnda rastgele yükseklik

            pipeBottom.Left = 700; // Alt borunun baþlangýç konumu
            pipeTop.Left = 700;    // Üst borunun baþlangýç konumu

            // Üst borunun yüksekliðini ayarla
            pipeTop.Size = new System.Drawing.Size(pipeWidth, topHeight);
            pipeTop.Top = 0; // Üst boru en üstte kalacak

            // Alt borunun yüksekliðini ayarla ve zeminle birleþmesini saðla
            int bottomHeight = this.ClientSize.Height - groundHeight - (topHeight + pipeGap);
            pipeBottom.Size = new System.Drawing.Size(pipeWidth, bottomHeight); // Alt borunun boyutunu ayarla
            pipeBottom.Top = this.ClientSize.Height - groundHeight; // Alt boru zeminle birleþecek

            // Borunun konumunu kontrol et
            if (bottomHeight < 0)
            {
                bottomHeight = 0; // Eðer borunun yüksekliði negatif olursa, sýfýra ayarla
            }
            pipeBottom.Top = this.ClientSize.Height - bottomHeight - groundHeight; // Alt borunun konumunu güncelle
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (isJumping)
            {
                velocity = -jumpSpeed; // Zýplama hareketi
                isJumping = false;      // Zýplama tamamlandý
            }
            else
            {
                velocity += gravity;   // Yerçekimi etkisi
            }

            flappyBird.Top += (int)velocity; // Kuþun yukarý ya da aþaðý hareketi

            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Skor: " + score;

            // Eðer borular ekran dýþýna çýkarsa, yeni borularý ayarlýyoruz
            if (pipeBottom.Left < -100)
            {
                resetPipes(); // Yeni borular için resetle
                score++; // Skoru artýr
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            if (flappyBird.Top < -25)
            {
                endGame();
            }

            // Kuþun zeminle çarpýþmasýný kontrol et
            if (flappyBird.Top + flappyBird.Height >= ground.Top)
            {
                flappyBird.Top = ground.Top - flappyBird.Height; // Kuþu zemine oturt
                velocity = 0; // Düþmeyi durdur
            }
        }

        private void jumpButton_Click(object sender, EventArgs e)
        {
            if (flappyBird.Top > 0) // Kuþun yukarý zýplamasýný saðla
            {
                isJumping = true; // Zýplama iþlemi baþlat
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Oyun Bitti!!!";
            startGame.Enabled = true; // Oyun bittiðinde Baþla butonunu tekrar aktif hale getir
        }
    }
}
