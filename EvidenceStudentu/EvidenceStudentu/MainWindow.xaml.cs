using MahApps.Metro.Controls;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System;
using System.Windows;

namespace EvidenceStudentu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : MetroWindow
    {
        static List<Student> seznamStudentu = new List<Student>();
        private string connectionString = "server=localhost;port=3306;user id=root;password=;" +
            "database=SkolaDB;";

        public MainWindow()
        {
            InitializeComponent();
            Database_Loaded();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PridatStudenta okno = new PridatStudenta(this);
            okno.ShowDialog();

        }

        private void lstboxChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = lstbox.SelectedItem as Student;
            if (selected == null) return;

            List<string> znamky = ZnamkyStudenta(selected.Id);

            if (znamky.Count == 0)
            {
                MessageBox.Show("Student nemá žádné známky.");
            }
            else
            {
                string text = string.Join(", ", znamky);
                MessageBox.Show($"Známky studenta:\n{text}");
            }
        }
        

       

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            /*  string cesta = "studenti.json";
              //  MessageBox.Show(Environment.CurrentDirectory);

              if (!File.Exists(cesta))
              {
                  MessageBox.Show("Soubor nebyl nalezen.");
                  return;
              }

              string json = File.ReadAllText(cesta);
              var options = new JsonSerializerOptions
              {
                  PropertyNameCaseInsensitive = true
              };

              seznamStudentu = JsonSerializer.Deserialize<List<Student>>(json, options);

              */
            StudentiDatabaze();
            MessageBox.Show($"Načteno studentů: {seznamStudentu.Count}");
            lstbox.ItemsSource = null;
            lstbox.ItemsSource = seznamStudentu;
        }
        private void Database_Loaded()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Připojení k databázi bylo úspěšné.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba připojení: " + ex.Message);
            }
        }
        public void StudentiDatabaze()
        {
            seznamStudentu.Clear();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Studenti";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["Vek"] != DBNull.Value)
                    {
                        Student s = new Student((string)reader["Jmeno"], (string)reader["Prijmeni"], (int)reader["Vek"]);
                        seznamStudentu.Add(s);
                    }
                    else
                    {
                        Student s = new Student((string)reader["Jmeno"], (string)reader["Prijmeni"], 0);
                        seznamStudentu.Add(s);
                    }  
                }
            }
            lstbox.ItemsSource = null;
            lstbox.ItemsSource = seznamStudentu;
        }
        public void PridatStudenta(string jmeno, string prijmeni, int vek)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Studenti (Jmeno, Prijmeni, Vek) VALUES (@jmeno, @prijmeni, @vek)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@jmeno", jmeno);
                cmd.Parameters.AddWithValue("@prijmeni", prijmeni);
                cmd.Parameters.AddWithValue("@vek", vek);

                cmd.ExecuteNonQuery();
            }
        }
        public List<string> ZnamkyStudenta(int idStudent)
        {
            List<string> znamky = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                @"SELECT z.oznaceni
          FROM hodnoceni h
          JOIN znamky z ON h.id_zn = z.id_zn
          WHERE h.id_st = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idStudent);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    znamky.Add(reader["oznaceni"].ToString());
                }
            }

            return znamky;
        }
        public void aktualizaceStranky()
        {
            lstbox.ItemsSource = null;
            lstbox.ItemsSource = seznamStudentu;
        }

        public void pridejStudentaDoListu(Student s)
        {
            seznamStudentu.Add(s);
        }

    }
  
}