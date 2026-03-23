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

namespace EvidenceStudentu
{
    /// <summary>
    /// Interakční logika pro PridatStudenta.xaml
    /// </summary>
    public partial class PridatStudenta : Window
    {
        private MainWindow hlavniOkno;
        public PridatStudenta(MainWindow okno)
        {
        InitializeComponent();
            hlavniOkno = okno;
        }

        private void BtnUlozit_Click(object sender, RoutedEventArgs e)
        {
            string jmeno = txtJmeno.Text;
            string prijmeni = txtPrijmeni.Text;
            int vek;           
                vek = int.Parse(txtVek.Text);
            
            hlavniOkno.PridatStudenta(jmeno, prijmeni, vek);
            Student s = new Student(jmeno, prijmeni, vek);
            hlavniOkno.pridejStudentaDoListu(s);
            hlavniOkno.aktualizaceStranky();
            this.Close();
        }
    }
}
