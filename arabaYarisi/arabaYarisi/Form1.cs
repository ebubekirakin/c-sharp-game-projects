using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace arabaYarisi
{
    public partial class Form1 : Form
    {
        // Skor i�in bir de�i�ken
        int skor = 0;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;  // Klavye olaylar�n�n formda i�lenmesini sa�lar�z

            // GameTimer'� ba�lat�yoruz
            gameTimer.Start();
        }

        // Form y�klendi�inde focus almas�n� sa�l�yoruz
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();  // Form �zerine focus al
        }

        // Oyuncu arabas�n� y�nlendirmek i�in kullan�lan KeyDown olay�
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.Focus();  // Klavye olaylar� form taraf�ndan al�ns�n

            // Sa� y�n tu�u
            if (e.KeyCode == Keys.Right)
            {
                // E�er oyuncu arabas� ekran�n sa� kenar�na �arpm�yorsa, sa�a hareket et
                if (pbOyuncuAraba.Left < this.ClientSize.Width - pbOyuncuAraba.Width)
                    pbOyuncuAraba.Left += 10; // 10 pixel sa�a hareket et
            }
            // Sol y�n tu�u
            if (e.KeyCode == Keys.Left)
            {
                // E�er oyuncu arabas� ekran�n sol kenar�na �arpm�yorsa, sola hareket et
                if (pbOyuncuAraba.Left > 0)
                    pbOyuncuAraba.Left -= 10; // 10 pixel sola hareket et
            }
        }

        // GameTimer tick olay�
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            this.Focus();  // Timer tick olay�nda da formun focus'lanmas�n� sa�la

            // Trafik arabalar�n� a�a��ya kayd�r�yoruz
            pbTrafik1.Top += 5;
            pbTrafik2.Top += 5;
            pbTrafik3.Top += 5;

            // Trafik arabalar�n�n ekrandan ��kt���n� kontrol et
            if (pbTrafik1.Top > this.ClientSize.Height)
            {
                pbTrafik1.Top = -100; // Yeniden �stten gelmesi i�in
                pbTrafik1.Left = new Random().Next(0, this.ClientSize.Width - pbTrafik1.Width); // Random x konumu
                skor++; // Skoru art�r
            }
            if (pbTrafik2.Top > this.ClientSize.Height)
            {
                pbTrafik2.Top = -100;
                pbTrafik2.Left = new Random().Next(0, this.ClientSize.Width - pbTrafik2.Width);
                skor++;
            }
            if (pbTrafik3.Top > this.ClientSize.Height)
            {
                pbTrafik3.Top = -100;
                pbTrafik3.Left = new Random().Next(0, this.ClientSize.Width - pbTrafik3.Width);
                skor++;
            }

            // Skoru g�ncelle
            lblSkor.Text = "Skor: " + skor;

            // �arpma kontrol� (�arpan arabalar� kontrol et)
            if (pbOyuncuAraba.Bounds.IntersectsWith(pbTrafik1.Bounds) || pbOyuncuAraba.Bounds.IntersectsWith(pbTrafik2.Bounds) || pbOyuncuAraba.Bounds.IntersectsWith(pbTrafik3.Bounds))
            {
                gameTimer.Stop(); // Oyun biter
                MessageBox.Show("Oyun Bitti! Skorunuz: " + skor);
            }
        }
    }
}


