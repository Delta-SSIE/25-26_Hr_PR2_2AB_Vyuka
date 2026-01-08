using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kalkulacka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textVypis.Text = textVypis.Text + "1";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textVypis.Text = textVypis.Text + "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textVypis.Text = textVypis.Text + "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string vyraz = textVypis.Text;
            textVypis.Text = "";
            if (string.IsNullOrWhiteSpace(vyraz))
                textVypis.Text = "prazdny vyraz";
            else
            {
                string[] cisla = new string[10];
                cisla = vyraz.Split('+', 10);
                for (int i = 0; i < cisla.Length; i++)
                {
                    textVypis.Text += cisla[i];
                }
                int cislo;
                int soucet = 0;
                for(int i = 0;i< cisla.Length; i++)
                {
                    if (int.TryParse(cisla[i], out cislo) == true)
                        soucet = soucet + cislo;

                }
                textVypis.Text = "" + soucet;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textVypis.Text = textVypis.Text + "+";
        }
    }
}