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
    /// Logika interakcji dla klasy popUp.xaml
    /// </summary>
    public partial class popUp : Window
    {
        public popUp(string rodzaj)
        {
            InitializeComponent();
            switch(rodzaj)
            {
                case "Cezar":
                    wynikPopUp.Text = cryptoCezar.wynikKodu;
                    break;
                case "Polibiusz":
                    wynikPopUp.Text = cryptoPolibiusz.wynikKodu;
                    break;
            }
        }

        public void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
