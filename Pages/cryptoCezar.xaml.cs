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
using static Crypto.Pages.Alfabet;

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
            Encoding encoding = Encoding.UTF8;

            byte[] bity = new byte[encoding.GetByteCount(napis)];
            bity = encoding.GetBytes(napis);

            int index = 0;
            int written = encoding.GetBytes(napis, 0, napis.Length, bity, index);
            index = written;
            

            string wyjscie = "";
            for (int ctr = 0; ctr <= index - 1; ctr++)
            {
                wyjscie += String.Format("{0:X2} ", bity[ctr]);

            }
            char[] tabelka = new char[wyjscie.Length];
            
            foreach (char codedBit in wyjscie)
            {
                tabelka.Append(codedBit);      
            }


            ///Nie działa.....
            string wyjscieEn = ""; 

            foreach (char zTabl in tabelka)
            {
                wyjscieEn += zTabl.ToString();
            }

            return wyjscieEn;
        }
    }
}
