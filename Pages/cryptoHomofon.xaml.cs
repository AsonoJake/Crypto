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
            if (setup.ShowDialog() == true)
            {
                zbioryTekst = setup.Zbiory;
            }
        }

        private void BtnEncode_Click(object sender, RoutedEventArgs e)
        {
            string tekst = zbioryTekst;
            
            popUp popup = new popUp("Homofon");
            popup.ShowDialog();
        }

        private void BtnDecode_Click(object sender, RoutedEventArgs e)
        {
            string tekst = kod_jawny.Text.ToLower().Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "");
            
            popUp popup = new popUp("Homofon");
            popup.ShowDialog();
        }
    }
}
