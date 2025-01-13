using System;
using System.IO;
using System.Windows.Forms;
namespace adamasmaca_1

{
    public partial class AdamAsmaca : Form
    {
        // Þehir isimleri listesi
        List<string> cities = new List<string> { "adana", "adýyaman", "afyonkarahisar", "aðrý", "aksaray", "amasya", "ankara", "antalya", "ardahan", "artvin",
        "aydýn", "balýkesir", "bartýn", "batman", "bayburt", "bilecik", "bingöl", "bitlis", "bolu", "burdur",
        "bursa", "çanakkale", "çankýrý", "çorum", "denizli", "diyarbakýr", "düzce", "edirne", "elazýð", "erzincan",
        "erzurum", "eskiþehir", "gaziantep", "giresun", "gümüþhane", "hakkari", "hatay", "ýðdýr", "isparta", "istanbul",
        "izmir", "kahramanmaraþ", "karabük", "karaman", "kars", "kastamonu", "kayseri", "kýrýkkale", "kýrklareli", "kýrþehir",
        "kilis", "kocaeli", "konya", "kütahya", "malatya", "manisa", "mardin", "mersin", "muðla", "muþ",
        "nevþehir", "niðde", "ordu", "osmaniye", "rize", "sakarya", "samsun", "siirt", "sinop", "sivas",
        "þanlýurfa", "þýrnak", "tekirdað", "tokat", "trabzon", "tunceli", "uþak", "van", "yalova", "yozgat", "zonguldak" };

        string selectedCity; // Seçilen þehir
        char[] displayedCity; // Maskeli þehir
        int remainingAttempts = 6; // Kalan tahmin hakký
        int wrongAttempts = 0; // Yanlýþ tahmin sayýsý

        public AdamAsmaca()
        {
            InitializeComponent();
            StartGame();
        }

        // Oyunu baþlatma fonksiyonu
        private void StartGame()
        {
            // Rastgele bir þehir seç
            Random rand = new Random();
            selectedCity = cities[rand.Next(cities.Count)].ToUpper();

            // Maskeli kelimeyi oluþtur (_ _ _ _ _ þeklinde)
            displayedCity = new string('_', selectedCity.Length).ToCharArray();

            // Harfler arasýnda boþluk ekleyerek label'da göster
            labelWord.Text = string.Join(" ", displayedCity);
            labelAttempts.Text = "Kalan Hak: " + remainingAttempts;
            wrongAttempts = 0;

            // Boþ resmi ekranda göster (empty.png)
            string imagePath = Path.Combine(Application.StartupPath, "Images", "empty.png");
            pictureBoxHangman.Image = Image.FromFile(imagePath); // Ýlk baþta boþ resmi göster

            // Yanlýþ tahmin edilen harfleri sýfýrla
            lblWrongWord.Text = "";
        }

        // Tahmin butonuna týklanma olayý
        private void buttonGuess_Click(object sender, EventArgs e)
        {
            string guess = textBoxGuess.Text.ToUpper();

            // Geçersiz giriþ kontrolü (boþ giriþ veya birden fazla harf)
            if (guess.Length != 1 || !char.IsLetter(guess[0]))
            {
                MessageBox.Show("Lütfen geçerli bir harf giriniz.");
                textBoxGuess.Clear();
                return;
            }

            char guessedLetter = guess[0]; // Girilen harfi al
            bool found = false;

            // Girilen harfi þehir içinde ara
            for (int i = 0; i < selectedCity.Length; i++)
            {
                if (selectedCity[i] == guessedLetter)
                {
                    displayedCity[i] = guessedLetter; // Doðru tahmin edilen harfi ekle
                    found = true;
                }
            }

            // Eðer doðru tahmin yapýldýysa kelimeyi güncelle
            if (found)
            {
                labelWord.Text = string.Join(" ", displayedCity); // Maskeli kelimeyi güncelle ve label'da göster
                if (!labelWord.Text.Contains('_')) // Eðer tüm harfler doðru tahmin edildiyse
                {
                    MessageBox.Show("KAZANDINIZ!");
                    StartGame(); // Oyunu yeniden baþlat
                }
            }
            else
            {
                // Yanlýþ tahmin durumu
                wrongAttempts++;
                remainingAttempts--;
                labelAttempts.Text = "Kalan Hak: " + remainingAttempts;
                UpdateHangmanImage(wrongAttempts); // Adam asmaca resmini güncelle

                // Yanlýþ tahmin edilen harfi lblWrongWord'de göster
                if (!lblWrongWord.Text.Contains(guessedLetter))
                {
                    lblWrongWord.Text += guessedLetter + " "; // Yanlýþ harfleri araya boþluk koyarak ekle
                }

                if (remainingAttempts == 0) // Eðer tahmin hakký biterse oyun sonlanýr
                {
                    MessageBox.Show("KAYBETTÝNÝZ! Doðru Kelime: " + selectedCity);
                    StartGame(); // Oyunu yeniden baþlat
                }
            }

            textBoxGuess.Clear(); // Harf doðru veya yanlýþ olsa da textBox temizlenir
        }

        // Adam asmaca görselini güncelleme fonksiyonu
        private void UpdateHangmanImage(int wrongAttempts)
        {
            string imagePath = Application.StartupPath; // Uygulama dizininden resimlere eriþim

            switch (wrongAttempts)
            {
                case 1:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "head.png")); // Baþ resmi
                    break;
                case 2:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "body.png")); // Gövde resmi
                    break;
                case 3:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "left_arm.png")); // Sol kol
                    break;
                case 4:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "right_arm.png")); // Sað kol
                    break;
                case 5:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "left_leg.png")); // Sol bacak
                    break;
                case 6:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "right_leg.png")); // Sað bacak
                    break;
            }
        }
    }
}