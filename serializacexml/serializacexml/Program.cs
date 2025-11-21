using System.Xml.Serialization;

namespace serializacexml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student { Jmeno = "Jan", Prijmeni = "Novak", Znamky = new List<int> { 1, 2, 3 } };
           Student student2 = new Student { Jmeno = "Petr", Prijmeni = "Svoboda", Znamky = new List<int> { 3, 3, 4 } };

            // Vytvoření třídy s studenty
           Trida trida = new Trida
            {
                Nazev = "3.A",
                SeznamStudentu = new List<Student> { student1, student2 }
            };

            // Serializace do XML
            XmlSerializer serializer = new XmlSerializer(typeof(Trida));
            using (StreamWriter writer = new StreamWriter("trida.xml"))
            {
                serializer.Serialize(writer, trida);
            }

            Console.WriteLine("Data byla úspěšně serializována do XML souboru.");
        }
    }
    }

