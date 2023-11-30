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
    /// Logika interakcji dla klasy homofonSetup.xaml
    /// </summary>
    public partial class homofonSetup : Window
    {
        string zbiory;
        public string Zbiory
        {
            get { return zbiory; } 
        }

        public homofonSetup()
        {
            InitializeComponent();
        }

        public void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            zbior1.Text = "1";
            zbior2.Text = "2";
            zbior3.Text = "3";
            zbior4.Text = "4";
            zbior5.Text = "5";
            zbior6.Text = "6";
            zbior7.Text = "7";
            zbior8.Text = "8";
            zbior9.Text = "9";
            zbior10.Text = "10";
            zbior11.Text = "11";
            zbior12.Text = "12";
            zbior13.Text = "13";
            zbior14.Text = "14";
            zbior15.Text = "15";
            zbior16.Text = "16";
            zbior17.Text = "17";
            zbior18.Text = "18";
            zbior19.Text = "19";
            zbior20.Text = "20";
            zbior21.Text = "21";
            zbior22.Text = "22";
            zbior23.Text = "23";
            zbior24.Text = "24";
            zbior25.Text = "25";
            zbior26.Text = "26";
            zbior27.Text = "27";
            zbior28.Text = "28";
            zbior29.Text = "29";
            zbior30.Text = "30";
            zbior31.Text = "31";
            zbior32.Text = "32";
            zbior33.Text = "33";
            zbior34.Text = "34";
            zbior35.Text = "35";
        }

        public void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            zbiory = zbior1.Text.ToLower() + ";" + zbior2.Text.ToLower() + ";" + zbior3.Text.ToLower() + ";" + zbior4.Text.ToLower() + ";" + zbior5.Text.ToLower() + ";" + zbior6.Text.ToLower() + ";" + zbior7.Text.ToLower() + ";" + zbior8.Text.ToLower() + ";" + zbior9.Text.ToLower() + ";" + zbior10.Text.ToLower() + ";" + zbior11.Text.ToLower() + ";" + zbior12.Text.ToLower() + ";" + zbior13.Text.ToLower() + ";" + zbior14.Text.ToLower() + ";" + zbior15.Text.ToLower() + ";" + zbior16.Text.ToLower() + ";" + zbior17.Text.ToLower() + ";" + zbior18.Text.ToLower() + ";" + zbior19.Text.ToLower() + ";" + zbior20.Text.ToLower() + ";" + zbior21.Text.ToLower() + ";" + zbior22.Text.ToLower() + ";" + zbior23.Text.ToLower() + ";" + zbior24.Text.ToLower() + ";" + zbior25.Text.ToLower() + ";" + zbior26.Text.ToLower() + ";" + zbior27.Text.ToLower() + ";" + zbior28.Text.ToLower() + ";" + zbior29.Text.ToLower() + ";" + zbior30.Text.ToLower() + ";" + zbior31.Text.ToLower() + ";" + zbior32.Text.ToLower() + ";" + zbior33.Text.ToLower() + ";" + zbior34.Text.ToLower() + ";" + zbior35.Text.ToLower();
            this.Close();
        }
    }
}
