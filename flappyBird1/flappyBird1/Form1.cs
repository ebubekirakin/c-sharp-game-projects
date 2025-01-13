using System;
using System.Windows.Forms;

namespace flappyBird1
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 10;                // Borular�n hareket h�z�
        double gravity = 0.8;              // Ku�un d���� h�z�
        double jumpSpeed = 12;             // Ku�un z�plama h�z�
        double velocity = 0;                // Ku�un mevcut h�z�
        int score = 0;                      // Skor
        const int pipeWidth = 60;           // Borular�n geni�li�i
        const int minPipeHeight = 50;       // Minimum �st boru y�ksekli�i
        const int maxPipeHeight = 400;      // Maksimum �st boru y�ksekli�i
        const int minPipeGap = 100;         // Borular aras�ndaki minimum bo�luk
        const int maxPipeGap = 200;         // Borular aras�ndaki maksimum bo�luk
        const int groundHeight = 62;        // Zemin y�ksekli�i
        Random rand = new Random();         // Rastgele say� �retici
        bool isJumping = false;             // Ku�un z�play�p z�plamad���n� kontrol etmek i�in

        public Form1()
        {
            InitializeComponent();

            gameTimer.Tick += new EventHandler(gameTimerEvent);
            gameTimer.Interval = 20;
            gameTimer.Enabled = false;

            startGame.Enabled = true; // Ba�la butonunu aktif hale getir
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            score = 0;
            scoreText.Text = "Skor: 0";

            flappyBird.Top = 200; // Ku�un ba�lang�� y�ksekli�i
            resetPipes(); // Borular� ayarla

            startGame.Enabled = false; // Ba�la butonunu devre d��� b�rak
        }

        private void resetPipes()
        {
            // Rastgele bo�luk ve �st boru y�ksekli�i belirle
            int pipeGap = rand.Next(minPipeGap, maxPipeGap);
            int topHeight = rand.Next(minPipeHeight, maxPipeHeight); // 50 ile 400 aras�nda rastgele y�kseklik

            pipeBottom.Left = 700; // Alt borunun ba�lang�� konumu
            pipeTop.Left = 700;    // �st borunun ba�lang�� konumu

            // �st borunun y�ksekli�ini ayarla
            pipeTop.Size = new System.Drawing.Size(pipeWidth, topHeight);
            pipeTop.Top = 0; // �st boru en �stte kalacak

            // Alt borunun y�ksekli�ini ayarla ve zeminle birle�mesini sa�la
            int bottomHeight = this.ClientSize.Height - groundHeight - (topHeight + pipeGap);
            pipeBottom.Size = new System.Drawing.Size(pipeWidth, bottomHeight); // Alt borunun boyutunu ayarla
            pipeBottom.Top = this.ClientSize.Height - groundHeight; // Alt boru zeminle birle�ecek

            // Borunun konumunu kontrol et
            if (bottomHeight < 0)
            {
                bottomHeight = 0; // E�er borunun y�ksekli�i negatif olursa, s�f�ra ayarla
            }
            pipeBottom.Top = this.ClientSize.Height - bottomHeight - groundHeight; // Alt borunun konumunu g�ncelle
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (isJumping)
            {
                velocity = -jumpSpeed; // Z�plama hareketi
                isJumping = false;      // Z�plama tamamland�
            }
            else
            {
                velocity += gravity;   // Yer�ekimi etkisi
            }

            flappyBird.Top += (int)velocity; // Ku�un yukar� ya da a�a�� hareketi

            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Skor: " + score;

            // E�er borular ekran d���na ��karsa, yeni borular� ayarl�yoruz
            if (pipeBottom.Left < -100)
            {
                resetPipes(); // Yeni borular i�in resetle
                score++; // Skoru art�r
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

            // Ku�un zeminle �arp��mas�n� kontrol et
            if (flappyBird.Top + flappyBird.Height >= ground.Top)
            {
                flappyBird.Top = ground.Top - flappyBird.Height; // Ku�u zemine oturt
                velocity = 0; // D��meyi durdur
            }
        }

        private void jumpButton_Click(object sender, EventArgs e)
        {
            if (flappyBird.Top > 0) // Ku�un yukar� z�plamas�n� sa�la
            {
                isJumping = true; // Z�plama i�lemi ba�lat
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Oyun Bitti!!!";
            startGame.Enabled = true; // Oyun bitti�inde Ba�la butonunu tekrar aktif hale getir
        }
    }
}