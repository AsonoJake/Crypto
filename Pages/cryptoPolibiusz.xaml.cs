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
    /// Logika interakcji dla klasy cryptoPolibiusz.xaml
    /// </summary>
    public partial class cryptoPolibiusz : Window
    {
        public static string wynikKodu = "Test";
        public cryptoPolibiusz()
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
            wynikKodu = PolibiuszekEn(tekst, GeneratePolibiusSquare());
            popUp popup = new popUp("Polibiusz");
            popup.ShowDialog();
        }

        private void BtnDecode_Click(object sender, RoutedEventArgs e)
        {
            string tekst = kod_jawny.Text.ToLower().Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "");
            wynikKodu = PolibiuszekDe(tekst, GeneratePolibiusSquare());
            popUp popup = new popUp("Polibiusz");
            popup.ShowDialog();
        }

        static string PolibiuszekEn(string napis, char[,] tabelka)
        {
            StringBuilder kod = new StringBuilder();

            foreach (char c in napis)
            {
                if (c == ' ')
                {
                    kod.Append(' ');
                    continue;
                }

                for (int i = 0; i < tabelka.GetLength(0); i++)
                {
                    for (int j = 0; j < tabelka.GetLength(1); j++)
                    {
                        if (tabelka[i, j] == c)
                        {
                            kod.Append((i + 1).ToString() + (j + 1).ToString() + " ");
                            break;
                        }
                    }
                }
            }

            return kod.ToString().Trim();
        }

        static string PolibiuszekDe(string encryptedText, char[,] square)
        {
            StringBuilder decryptedText = new StringBuilder();
            string[] parts = encryptedText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string part in parts)
            {
                try
                {
                    int row = int.Parse(part[0].ToString()) - 1;
                    int col = int.Parse(part[1].ToString()) - 1;
                    decryptedText.Append(square[row, col]);
                }
                catch (Exception)
                {
                    return "Niepoprawny format tekstu!!!";
                } 
            }

            return decryptedText.ToString();
        }

        static char[,] GeneratePolibiusSquare()
        {
            string alphabet = "aąbcćdeęfghijklłmnńoópqrsśtuvwyzźż";
            int size = (int)Math.Ceiling(Math.Sqrt(alphabet.Length));
            char[,] square = new char[size, size];
            int index = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (index < alphabet.Length)
                        square[i, j] = alphabet[index++];
                }
            }

            return square;
        }
    }
}
