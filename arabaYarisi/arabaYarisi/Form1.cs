using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace arabaYarisi
{

    
    public partial class Form1 : Form
    {
        // Skor için bir deðiþken
        int skor = 0;


        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;  // Klavye olaylarýnýn formda iþlenmesini saðlarýz

            // GameTimer'ý baþlatýyoruz
            gameTimer.Start();
        }

        // Form yüklendiðinde focus almasýný saðlýyoruz
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();  // Form üzerine focus al
        }

        // Oyuncu arabasýný yönlendirmek için kullanýlan KeyDown olayý
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
         
            this.Focus();  // Klavye olaylarý form tarafýndan alýnsýn

            // Sað yön tuþu
            if (e.KeyCode == Keys.Right)
            {
                // Eðer oyuncu arabasý ekranýn sað kenarýna çarpmýyorsa, saða hareket et
                if (pbOyuncuAraba.Left < this.ClientSize.Width - pbOyuncuAraba.Width)
                    pbOyuncuAraba.Left += 10; // 10 pixel saða hareket et
            }
            // Sol yön tuþu
            if (e.KeyCode == Keys.Left)
            {
                // Eðer oyuncu arabasý ekranýn sol kenarýna çarpmýyorsa, sola hareket et
                if (pbOyuncuAraba.Left > 0)
                    pbOyuncuAraba.Left -= 10; // 10 pixel sola hareket et
            }
        }

        // GameTimer tick olayý
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            this.Focus();  // Timer tick olayýnda da formun focus'lanmasýný saðla

            // Trafik arabalarýný aþaðýya kaydýrýyoruz
            pbTrafik1.Top += 5;
            pbTrafik2.Top += 5;
            pbTrafik3.Top += 5;

            // Trafik arabalarýnýn ekrandan çýktýðýný kontrol et
            if (pbTrafik1.Top > this.ClientSize.Height)
            {
                pbTrafik1.Top = -100; // Yeniden üstten gelmesi için
                pbTrafik1.Left = new Random().Next(0, this.ClientSize.Width - pbTrafik1.Width); // Random x konumu
                skor++; // Skoru artýr
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

            // Skoru güncelle
            lblSkor.Text = "Skor: " + skor;

            // Çarpma kontrolü (çarpan arabalarý kontrol et)
            if (pbOyuncuAraba.Bounds.IntersectsWith(pbTrafik1.Bounds) || pbOyuncuAraba.Bounds.IntersectsWith(pbTrafik2.Bounds) || pbOyuncuAraba.Bounds.IntersectsWith(pbTrafik3.Bounds))
            {
                gameTimer.Stop(); // Oyun biter
                MessageBox.Show("Oyun Bitti! Skorunuz: " + skor);
            }
        }
    }
}


