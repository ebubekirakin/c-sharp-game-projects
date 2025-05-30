using System;
using System.IO;
using System.Windows.Forms;
namespace adamasmaca_1

{
    
public partial class AdamAsmaca : Form
    {
        // Şehir isimleri listesi
        List<string> cities = new List<string> { "adana", "adıyaman", "afyonkarahisar", "ağrı", "aksaray", "amasya", "ankara", "antalya", "ardahan", "artvin",
        "aydın", "balıkesir", "bartın", "batman", "bayburt", "bilecik", "bingöl", "bitlis", "bolu", "burdur",
        "bursa", "çanakkale", "çankırı", "çorum", "denizli", "diyarbakır", "düzce", "edirne", "elazığ", "erzincan",
        "erzurum", "eskişehir", "gaziantep", "giresun", "gümüşhane", "hakkari", "hatay", "ığdır", "isparta", "istanbul",
        "izmir", "kahramanmaraş", "karabük", "karaman", "kars", "kastamonu", "kayseri", "kırıkkale", "kırklareli", "kırşehir",
        "kilis", "kocaeli", "konya", "kütahya", "malatya", "manisa", "mardin", "mersin", "muğla", "muş",
        "nevşehir", "niğde", "ordu", "osmaniye", "rize", "sakarya", "samsun", "siirt", "sinop", "sivas",
        "şanlıurfa", "şırnak", "tekirdağ", "tokat", "trabzon", "tunceli", "uşak", "van", "yalova", "yozgat", "zonguldak" };

        string selectedCity; // Seçilen şehir
        char[] displayedCity; // Maskeli şehir
        int remainingAttempts = 6; // Kalan tahmin hakkı
        int wrongAttempts = 0; // Yanlış tahmin sayısı

        public AdamAsmaca()
        {
            InitializeComponent();
            StartGame();
        }

        // Oyunu başlatma fonksiyonu
        private void StartGame()
        {
            // Rastgele bir şehir seç
            Random rand = new Random();
            selectedCity = cities[rand.Next(cities.Count)].ToUpper();

            // Maskeli kelimeyi oluştur (_ _ _ _ _ şeklinde)
            displayedCity = new string('_', selectedCity.Length).ToCharArray();

            // Harfler arasında boşluk ekleyerek label'da göster
            labelWord.Text = string.Join(" ", displayedCity);
            labelAttempts.Text = "Kalan Hak: " + remainingAttempts;
            wrongAttempts = 0;

            // Boş resmi ekranda göster (empty.png)
            string imagePath = Path.Combine(Application.StartupPath, "Images", "empty.png");
            pictureBoxHangman.Image = Image.FromFile(imagePath); // İlk başta boş resmi göster

            // Yanlış tahmin edilen harfleri sıfırla
            lblWrongWord.Text = "";
        }

        // Tahmin butonuna tıklanma olayı
        private void buttonGuess_Click(object sender, EventArgs e)
        {
            string guess = textBoxGuess.Text.ToUpper();

            // Geçersiz giriş kontrolü (boş giriş veya birden fazla harf)
            if (guess.Length != 1 || !char.IsLetter(guess[0]))
            {
                MessageBox.Show("Lütfen geçerli bir harf giriniz.");
                textBoxGuess.Clear();
                return;
            }

            char guessedLetter = guess[0]; // Girilen harfi al
            bool found = false;

            // Girilen harfi şehir içinde ara
            for (int i = 0; i < selectedCity.Length; i++)
            {
                if (selectedCity[i] == guessedLetter)
                {
                    displayedCity[i] = guessedLetter; // Doğru tahmin edilen harfi ekle
                    found = true;
                }
            }

            // Eğer doğru tahmin yapıldıysa kelimeyi güncelle
            if (found)
            {
                labelWord.Text = string.Join(" ", displayedCity); // Maskeli kelimeyi güncelle ve label'da göster
                if (!labelWord.Text.Contains('_')) // Eğer tüm harfler doğru tahmin edildiyse
                {
                    MessageBox.Show("KAZANDINIZ!");
                    StartGame(); // Oyunu yeniden başlat
                }
            }
            else
            {
                // Yanlış tahmin durumu
                wrongAttempts++;
                remainingAttempts--;
                labelAttempts.Text = "Kalan Hak: " + remainingAttempts;
                UpdateHangmanImage(wrongAttempts); // Adam asmaca resmini güncelle

                // Yanlış tahmin edilen harfi lblWrongWord'de göster
                if (!lblWrongWord.Text.Contains(guessedLetter))
                {
                    lblWrongWord.Text += guessedLetter + " "; // Yanlış harfleri araya boşluk koyarak ekle
                }

                if (remainingAttempts == 0) // Eğer tahmin hakkı biterse oyun sonlanır
                {
                    MessageBox.Show("KAYBETTİNİZ! Doğru Kelime: " + selectedCity);
                    StartGame(); // Oyunu yeniden başlat
                }
            }

            textBoxGuess.Clear(); // Harf doğru veya yanlış olsa da textBox temizlenir
        }

        // Adam asmaca görselini güncelleme fonksiyonu
        private void UpdateHangmanImage(int wrongAttempts)
        {
            string imagePath = Application.StartupPath; // Uygulama dizininden resimlere erişim

            switch (wrongAttempts)
            {
                case 1:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "head.png")); // Baş resmi
                    break;
                case 2:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "body.png")); // Gövde resmi
                    break;
                case 3:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "left_arm.png")); // Sol kol
                    break;
                case 4:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "right_arm.png")); // Sağ kol
                    break;
                case 5:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "left_leg.png")); // Sol bacak
                    break;
                case 6:
                    pictureBoxHangman.Image = Image.FromFile(Path.Combine(imagePath, "right_leg.png")); // Sağ bacak
                    break;
            }
        }
    }
}