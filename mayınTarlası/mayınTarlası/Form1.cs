using System;
using System.Drawing;
using System.Windows.Forms;

namespace mayınTarlası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Oyun başlatma butonuna tıklama
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            // Mayın sayısını ve alan boyutlarını al
            int mayinSayisi = int.Parse(txtMayinSayisi.Text);  // TextBox'tan mayın sayısını al
            int satirSayisi = 10;  // Satır sayısını belirleyelim
            int sutunSayisi = 10;  // Sütun sayısını belirleyelim

            // Paneli temizle
            pnlMayinTarlasi.Controls.Clear();
            pnlMayinTarlasi.Width = satirSayisi * 30;
            pnlMayinTarlasi.Height = sutunSayisi * 30;

            // Butonları panelin içine ekle
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    Button btn = new Button();
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.Tag = "0"; // Mayın olmadığını belirtir
                    btn.Click += Btn_Click; // Butona tıklama eventini bağla
                    pnlMayinTarlasi.Controls.Add(btn);
                    btn.Location = new Point(j * 30, i * 30);
                }
            }

            // Mayınları yerleştir
            YerleştirMayinlar(mayinSayisi, satirSayisi, sutunSayisi);
        }

        // Mayınları rastgele yerleştiren fonksiyon
        private void YerleştirMayinlar(int mayinSayisi, int satirSayisi, int sutunSayisi)
        {
            Random rand = new Random();
            int mayinlarYerlesen = 0;

            while (mayinlarYerlesen < mayinSayisi)
            {
                int satir = rand.Next(satirSayisi);
                int sutun = rand.Next(sutunSayisi);
                Button btn = (Button)pnlMayinTarlasi.Controls[satir * sutunSayisi + sutun];

                // Eğer butonun Tag'ı zaten "1" (mayın) ise tekrar yerleştirme
                if (btn.Tag.ToString() == "1") continue;

                btn.Tag = "1"; // Butona mayın yerleştir
                mayinlarYerlesen++;
            }
        }

        // Buton tıklama işlemi
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Tag.ToString() == "1") // Eğer mayın varsa
            {
                lblDurum.Text = "Kaybettiniz!";
                MessageBox.Show("Mayına bastınız! Oyunu kaybettiniz.");
                OyunBitir();
            }
            else
            {
                btn.BackColor = Color.Green; // Mayın olmayan butonu yeşil yap
                btn.Enabled = false; // Butonu devre dışı bırak

                // Etrafındaki mayın sayısını göster
                int etrafindakiMayinSayisi = HesaplaEtrafindakiMayinSayisi(btn);
                if (etrafindakiMayinSayisi > 0)
                {
                    btn.Text = etrafindakiMayinSayisi.ToString(); // Sayıyı butona yaz
                }

                // Kazanma kontrolü yapılabilir, eğer tüm mayınlar hariç butonlar açıldıysa
                KazanmaKontrol();
            }
        }

        // Etrafındaki mayın sayısını hesaplayan fonksiyon
        private int HesaplaEtrafindakiMayinSayisi(Button btn)
        {
            int mayinSayisi = 0;
            int satirSayisi = 10;
            int sutunSayisi = 10;
            int index = pnlMayinTarlasi.Controls.IndexOf(btn);
            int satir = index / sutunSayisi;
            int sutun = index % sutunSayisi;

            // Etrafındaki 8 butonu kontrol et
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int yeniSatir = satir + i;
                    int yeniSutun = sutun + j;
                    if (yeniSatir >= 0 && yeniSatir < satirSayisi && yeniSutun >= 0 && yeniSutun < sutunSayisi)
                    {
                        Button etrafButon = (Button)pnlMayinTarlasi.Controls[yeniSatir * sutunSayisi + yeniSutun];
                        if (etrafButon.Tag.ToString() == "1") // Eğer etrafındaki butonda mayın varsa
                        {
                            mayinSayisi++;
                        }
                    }
                }
            }
            return mayinSayisi;
        }

        // Kazanma kontrolü
        private void KazanmaKontrol()
        {
            foreach (Button btn in pnlMayinTarlasi.Controls)
            {
                if (btn.Tag.ToString() == "0" && btn.Enabled == true)
                {
                    return; // Eğer hala açılmamış buton varsa, kazandınız diyemeyiz
                }
            }

            lblDurum.Text = "Kazandınız!";
            MessageBox.Show("Tebrikler! Kazandınız.");
            OyunBitir();
        }

        // Oyunu bitiren fonksiyon
        private void OyunBitir()
        {
            foreach (Button btn in pnlMayinTarlasi.Controls)
            {
                btn.Enabled = false; // Butonları devre dışı bırak
            }
        }
    }
}

