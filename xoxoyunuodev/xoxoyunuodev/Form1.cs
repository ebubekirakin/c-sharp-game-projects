using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace xoxoyunuodev
{
    public partial class Form1 : Form
    {
        private int boyut;  // Tablo boyutu
        private Button[,] butonlar;  // Oyun tahtasýndaki butonlarý tutar
        private bool siradaX;  // X mi, yoksa O mu sýrada olduðunu belirtir  
        private int skorOyuncu1 = 0;  // Oyuncu 1'in skoru
        private int skorOyuncu2 = 0;  // Oyuncu 2'nin skoru

        public Form1()
        {
            InitializeComponent();
            siradaX = true;  // Oyun X ile baþlar
            cmbBoyutSecimi.Items.AddRange(new object[] { "3x3", "5x5", "7x7" });
            btnBasla.Click += BtnBasla_Click;
        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            // Ýsimleri kontrol et
            if (string.IsNullOrEmpty(txtOyuncu1.Text) || string.IsNullOrEmpty(txtOyuncu2.Text))
            {
                MessageBox.Show("Lütfen oyuncu isimlerini giriniz.");
                return;
            }

            // Seçime göre tablo boyutunu belirle
            if (cmbBoyutSecimi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tablo boyutunu seçiniz.");
                return;
            }

            // Baþlangýçtaki label ve textboxlarý gizle
            lblOyuncu1.Visible = false;
            txtOyuncu1.Visible = false;
            lblOyuncu2.Visible = false;
            txtOyuncu2.Visible = false;
            lblSkorlar.Visible = false;
            lblSkorOyuncu1.Visible = true;  // Skorlarý göstermek için sadece skor etiketini görünür yapabiliriz
            lblSkorOyuncu2.Visible = true;
            cmbBoyutSecimi.Visible = false;
            btnBasla.Visible = false;

            // Oyun tahtasýný oluþtur
            string secim = cmbBoyutSecimi.SelectedItem.ToString();
            boyut = int.Parse(secim.Substring(0, 1));
            pnlOyunAlani.Controls.Clear();
            butonlar = new Button[boyut, boyut];
            pnlOyunAlani.Size = new Size(boyut * 50, boyut * 50);
            pnlOyunAlani.Location = new Point((Width - pnlOyunAlani.Width) / 2, (Height - pnlOyunAlani.Height) / 2);

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    Button btn = new Button
                    {
                        Width = 50,
                        Height = 50,
                        Location = new Point(i * 50, j * 50),
                        Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold),
                        Tag = new Point(i, j)
                    };
                    btn.Click += Buton_Click;
                    pnlOyunAlani.Controls.Add(btn);
                    butonlar[i, j] = btn;
                }
            }

            // Skorlarý sýfýrla
            lblSkorOyuncu1.Text = $"{txtOyuncu1.Text}: {skorOyuncu1}";
            lblSkorOyuncu2.Text = $"{txtOyuncu2.Text}: {skorOyuncu2}";
        }

        private void Buton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text != "") return;

            btn.Text = siradaX ? "X" : "O";
            siradaX = !siradaX;

            if (KazananKontrol())
            {
                string kazanan = siradaX ? "O" : "X"; // Kazanan oyuncuyu tespit et

                // Kazananýn adýný belirle
                string kazananOyuncu = kazanan == "X" ? txtOyuncu1.Text : txtOyuncu2.Text;
                MessageBox.Show($"{kazananOyuncu} kazandý!");

                // Skoru güncelle
                if (kazanan == "X")
                    skorOyuncu1++;
                else
                    skorOyuncu2++;

                lblSkorOyuncu1.Text = $"{txtOyuncu1.Text}: {skorOyuncu1}";
                lblSkorOyuncu2.Text = $"{txtOyuncu2.Text}: {skorOyuncu2}";

                Temizle();
            }
            else if (BerabereKontrol())
            {
                MessageBox.Show("Berabere!");
                Temizle();
            }
        }

        private bool KazananKontrol()
        {
            for (int i = 0; i < boyut; i++)
            {
                if (SatirKontrol(i) || SutunKontrol(i))
                    return true;
            }
            return CaprazKontrol();
        }

        private bool SatirKontrol(int satir)
        {
            string ilkDeger = butonlar[satir, 0].Text;
            if (string.IsNullOrEmpty(ilkDeger)) return false;

            for (int i = 1; i < boyut; i++)
            {
                if (butonlar[satir, i].Text != ilkDeger)
                    return false;
            }
            return true;
        }

        private bool SutunKontrol(int sutun)
        {
            string ilkDeger = butonlar[0, sutun].Text;
            if (string.IsNullOrEmpty(ilkDeger)) return false;

            for (int i = 1; i < boyut; i++)
            {
                if (butonlar[i, sutun].Text != ilkDeger)
                    return false;
            }
            return true;
        }

        private bool CaprazKontrol()
        {
            string ilkDeger = butonlar[0, 0].Text;
            bool kazandi = !string.IsNullOrEmpty(ilkDeger);
            for (int i = 1; i < boyut; i++)
            {
                if (butonlar[i, i].Text != ilkDeger)
                {
                    kazandi = false;
                    break;
                }
            }
            if (kazandi) return true;

            ilkDeger = butonlar[0, boyut - 1].Text;
            kazandi = !string.IsNullOrEmpty(ilkDeger);
            for (int i = 1; i < boyut; i++)
            {
                if (butonlar[i, boyut - i - 1].Text != ilkDeger)
                {
                    kazandi = false;
                    break;
                }
            }
            return kazandi;
        }

        private bool BerabereKontrol()
        {
            foreach (var btn in butonlar)
            {
                if (string.IsNullOrEmpty(btn.Text))
                    return false;
            }
            return true;
        }

        private void Temizle()
        {
            foreach (var btn in butonlar)
            {
                btn.Text = "";
            }
            siradaX = true;
        }
    }
}

