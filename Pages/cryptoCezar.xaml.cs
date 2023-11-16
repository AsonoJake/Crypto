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
            string tekst = kod_jawny.Text.ToLower();
            int key = Convert.ToInt32(klucz.Text);
            wynikKodu = CezarekEn(tekst, key);
            popUp popup = new popUp();
            popup.ShowDialog();
        }

        private void BtnDecode_Click(object sender, RoutedEventArgs e)
        {

        }

        string CezarekEn(string napis, int k)
        {
            char[] chars = napis.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                    continue;

                chars[i] += (char)k;

                if (chars[i] > 'Z')
                    chars[i] -= (char)34;
            }

            string wynik = new string(chars);
            return wynik.Replace(" ", "");
        }

        static bool IsPolishCharacter(char c)
        {
            return (c >= 'ą' && c <= 'ż') || (c >= 'Ą' && c <= 'Ż');
        }

        static bool IsUpperCasePolishCharacter(char c)
        {
            return (c >= 'Ą' && c <= 'Ż');
        }
    }
}
