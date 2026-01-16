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

namespace EvidenceStudentu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> seznamStudentu = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string j, p;
            int v;
         j = txtjmeno.Text;
            p = txtprijmeni.Text;
           v = int.Parse(txtvek.Text);
           Student s = new Student(j, p, v);
            seznamStudentu.Add(s);
            txbZobrazeni.Text = s.ToString();
        }
    }
}