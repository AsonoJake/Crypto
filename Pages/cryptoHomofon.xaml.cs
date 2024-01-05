using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Crypto.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy cryptoHomofon.xaml
    /// </summary>
    public partial class cryptoHomofon : Window
    {
        string zbioryTekst = "";
        public static string wynikKodu = "";

        public cryptoHomofon()
        {
            InitializeComponent();
        }

        public void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            homofonSetup setup = new homofonSetup();
            if (setup.ShowDialog() == false)
            {
                zbioryTekst = setup.Zbiory;
            }
        }

        private void BtnEncode_Click(object sender, RoutedEventArgs e)
        {

            string tekst = kod_jawny.Text.ToLower().Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "");
            wynikKodu = HomofonEn(tekst, zbioryTekst);
            popUp popup = new popUp("Homofon");
            popup.ShowDialog();
        }

        private void BtnDecode_Click(object sender, RoutedEventArgs e)
        {
            string tekst = kod_jawny.Text.ToLower().Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "");
            wynikKodu = HomofonDe(tekst, zbioryTekst);
            popUp popup = new popUp("Homofon");
            popup.ShowDialog();
        }

        static string HomofonEn(string napis, string zbiory)
        {
            Random rand = new Random();
            string wynik = "";
            Dictionary<char, string[]> zbioryAlfabet = new Dictionary<char, string[]>();
            string[] stringArray = zbiory.Split(';');
            List<string> adjustedStringArray = new List<string>(); // Changed to List<string>

            foreach (var str in stringArray)
            {
                if (str.Contains(','))
                {
                    adjustedStringArray.AddRange(str.Split(',')); // Changed to Split(',')
                }
                else
                {
                    adjustedStringArray.Add(str);
                }
            }

            char[] litery = "aąbcćdeęfghijklłmnńoópqrsśtuvwyzźż".ToCharArray();
            for (int i = 0; i < litery.Length && i < adjustedStringArray.Count; i++)
            {
                string value = adjustedStringArray[i];
                if (value.Contains(","))
                {
                    zbioryAlfabet.Add(litery[i], value.Split(','));
                }
                else
                {
                    zbioryAlfabet.Add(litery[i], new string[] { value });
                }
            }

            foreach (char c in napis.Replace(" ", ""))
            {
                if (zbioryAlfabet.ContainsKey(c))
                {
                    string[] possibleValues = zbioryAlfabet[c];
                    int index = rand.Next(0, possibleValues.Length);
                    wynik += possibleValues[index] + " ";
                }
                else
                {
                    wynik += c + " ";
                }
            }

            return wynik;
        }

        static string HomofonDe(string encodedText, string zbiory)
        {
            Dictionary<char, string[]> zbioryAlfabet = new Dictionary<char, string[]>();
            string[] stringArray = zbiory.Split(';');
            List<string> adjustedStringArray = new List<string>();

            foreach (var str in stringArray)
            {
                if (str.Contains(','))
                {
                    adjustedStringArray.AddRange(str.Split(','));
                }
                else
                {
                    adjustedStringArray.Add(str);
                }
            }

            char[] litery = "aąbcćdeęfghijklłmnńoópqrsśtuvwyzźż".ToCharArray();
            for (int i = 0; i < litery.Length && i < adjustedStringArray.Count; i++)
            {
                string value = adjustedStringArray[i];
                if (value.Contains(","))
                {
                    zbioryAlfabet.Add(litery[i], value.Split(','));
                }
                else
                {
                    zbioryAlfabet.Add(litery[i], new string[] { value });
                }
            }

            string[] encodedArray = encodedText.Split(' ');
            string decodedText = "";

            foreach (string enc in encodedArray)
            {
                bool found = false;
                foreach (var kvp in zbioryAlfabet)
                {
                    if (kvp.Value.Contains(enc))
                    {
                        decodedText += kvp.Key;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    decodedText += enc;
                }
            }

            return decodedText;
        }
    }
}
