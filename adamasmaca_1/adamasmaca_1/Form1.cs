using System;
using System.IO;
using System.Windows.Forms;
namespace adamasmaca_1

{
    public partial class AdamAsmaca : Form
    {
        // �ehir isimleri listesi
        List<string> cities = new List<string> { "adana", "ad�yaman", "afyonkarahisar", "a�r�", "aksaray", "amasya", "ankara", "antalya", "ardahan", "artvin",
        "ayd�n", "bal�kesir", "bart�n", "batman", "bayburt", "bilecik", "bing�l", "bitlis", "bolu", "burdur",
        "bursa", "�anakkale", "�ank�r�", "�orum", "denizli", "diyarbak�r", "d�zce", "edirne", "elaz��", "erzincan",
        "erzurum", "eski�ehir", "gaziantep", "giresun", "g�m��hane", "hakkari", "hatay", "��d�r", "isparta", "istanbul",
        "izmir", "kahramanmara�", "karab�k", "karaman", "kars", "kastamonu", "kayseri", "k�r�kkale", "k�rklareli", "k�r�ehir",
        "kilis", "kocaeli", "konya", "k�tahya", "malatya", "manisa", "mardin", "mersin", "mu�la", "mu�",
        "nev�ehir", "ni�de", "ordu", "osmaniye", "rize", "sakarya", "samsun", "siirt", "sinop", "sivas",
        "�anl�urfa", "��rnak", "tekirda�", "tokat", "trabzon", "tunceli", "u�ak", "van", "yalova", "yozgat", "zonguldak" };

        string selectedCity; // Se�ilen �ehir
        char[] displayedCity; // Maskeli �ehir
        int remainingAttempts = 6; // Kalan tahmin hakk�
        int wrongAttempts = 0; // Yanl�� tahmin say�s�

        public AdamAsmaca()
        {
            InitializeComponent();
            StartGame();
        }

        // Oyunu ba�latma fonksiyonu
        private void StartGame()
        {
            // Rastgele bir �ehir se�
            Random rand = new Random();
            selectedCity = cities[rand.Next(cities.Count)].ToUpper();

            // Maskeli kelimeyi olu�tur (_ _ _ _ _ �eklinde)
            displayedCity = new string('_', selectedCity.Length).ToCharArray();

            // Harfler aras�nda bo�luk ekleyerek label'da g�ster
            labelWord.Text = string.Join(" ", displayedCity);
            labelAttempts.Text = "Kalan Hak: " + remainingAttempts;
            wrongAttempts = 0;

            // Bo� resmi ekranda g�ster (empty.png)
            string imagePath = Path.Combine(Application.StartupPath, "Images", "empty.png");
            pictureBoxHangman.Image = Image.FromFile(imagePath); // �lk ba�ta bo� resmi g�ster

            // Yanl�� tahmin edilen harfleri s�f�rla
            lblWrongWord.Text = "";
        }

        // Tahmin butonuna t�klanma olay�
        private void buttonGuess_Click(object sender, EventArgs e)
        {
            string guess = textBoxGuess.Text.ToUpper();

            // Ge�ersiz giri� kontrol� (bo� giri� veya birden fazla harf)
            if (guess.Length != 1 || !char.IsLetter(guess[0]))
            {
                MessageBox.Show("L�tfen ge�erli bir harf giriniz.");
                textBoxGuess.Clear();
                return;
            }

            char guessedLetter = guess[0]; // Girilen harfi al
            bool found = false;

            // Girilen harfi �ehir i�inde ara
            for (int i = 0; i < selectedCity.Length; i++)
            {
                if (selectedCity[i] == guessedLetter)
                {
                    displayedCity[i] = guessedLetter; // Do�ru tahmin edilen harfi ekle
                    found = true;
                }
            }

            // E�er do�ru tahmin yap�ld�ysa kelimeyi g�ncelle
            if (found)
            {
                labelWord.Text = string.Join(" ", displayedCity); // Maskeli kelimeyi g�ncelle ve label'da g�ster
                if (!labelWord.Text.Contains('_')) // E�er t�m harfler do�ru tahmin edildiyse
                {
                    MessageBox.Show("KAZANDINIZ!");
                    StartGame(); // Oyunu yeniden ba�lat
                }
            }
            else
            {
                // Yanl�� tahmin durumu
                wrongAttempts++;
                remainingAttempts--;
                labelAttempts.Text = "Kalan Hak: " + remainingAttempts;
                UpdateHangmanImage(wrongAttempts); // Adam asmaca resmini g�ncelle

                // Yanl�� tahmin edilen harfi lblWrongWord'de g�ster
                if (!lblWrongWord.Text.Contains(guessedLetter))
                {
                    lblWrongWord.Text += guessedLetter + " "; // Yanl�� harfleri araya bo�luk koyarak ekle
                }

                if (remainingAttempts == 0) // E�er tahmin hakk� biterse oyun sonlan�r
                {
                    MessageBox.Show("KAYBETT�N�Z! Do�ru Kelime: " + selectedCity);
                    StartGame(); // Oyunu yeniden ba�lat
                }
            }

            textBoxGuess.Clear(); // Harf do�ru veya yanl�� olsa da textBox temizlenir
        }

        // Adam asmaca g�rselini g�ncelleme fonksiyonu
        private void UpdateHangmanImage(int wrongAttempts)
        {
            string imagePath = Application.StartupPath; // Uygulama dizininden resimlere eri�im

            switch (wrongAttempts)
            {
                case 1:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "head.png")); // Ba� resmi
                    break;
                case 2:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "body.png")); // G�vde resmi
                    break;
                case 3:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "left_arm.png")); // Sol kol
                    break;
                case 4:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "right_arm.png")); // Sa� kol
                    break;
                case 5:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "left_leg.png")); // Sol bacak
                    break;
                case 6:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "right_leg.png")); // Sa� bacak
                    break;
            }
        }
    }
}