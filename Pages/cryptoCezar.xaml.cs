using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Crypto.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy cryptoCezar.xaml
    /// </summary> 

    public partial class cryptoCezar : Window
    {
        public static string wynikKodu = "Test";
        public cryptoCezar()
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

        private void BtnEncode_Click(object sender, RoutedEventArgs e)
        {
            string tekst = kod_jawny.Text.ToLower().Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "");
            int key = Convert.ToInt32(klucz.Text);
            wynikKodu = CezarekEn(tekst, key) + " - " + key.ToString();
            popUp popup = new popUp("Cezar");
            popup.ShowDialog();
        }

        private void BtnDecode_Click(object sender, RoutedEventArgs e)
        {
            string tekst = kod_jawny.Text.ToLower();
            int key = Convert.ToInt32(klucz.Text);
            wynikKodu = CezarekDe(tekst, key);
            popUp popup = new popUp("Cezar");
            popup.ShowDialog();
        }

        string CezarekEn(string napis, int k)
        {
            string alphabet = "aąbcćdeęfghijklłmnńoópqrsśtuvwyzźż";
            string encrypted = "";

            foreach (char c in napis)
            {
                if (char.IsLetter(c))
                {
                    int index = alphabet.IndexOf(c);
                    if (index != -1)
                    {
                        int shiftedIndex = (index + k) % alphabet.Length;
                        encrypted += alphabet[shiftedIndex];
                    }
                }
                else
                {
                    encrypted += c;
                }
            }
            return encrypted;
        }

        string CezarekDe(string  napis, int k)
        {
            string alphabet = "aąbcćdeęfghijklłmnńoópqrsśtuvwyzźż";
            string decrypted = "";

            foreach (char c in napis)
            {
                if (char.IsLetter(c))
                {
                    int index = alphabet.IndexOf(c);
                    if (index != -1)
                    {
                        int shiftedIndex = (index - k + alphabet.Length) % alphabet.Length;
                        decrypted += alphabet[shiftedIndex];
                    }
                }
                else
                {
                    decrypted += c;
                }
            }
            return decrypted;
        }
    }
}
