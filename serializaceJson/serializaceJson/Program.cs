using System.Text.Json;

namespace serializaceJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student { Jmeno = "Eva", Prijmeni = "Horakova"} ;
            Student student2 = new Student { Jmeno = "Jakub", Prijmeni = "Dvorak" };

            // Vytvoření třídy s studenty
            Trida trida = new Trida
            {
                Nazev = "2.B",
                SeznamStudentu = new List<Student> { student1, student2 }
            };

            // Serializace do JSON
            string jsonString = JsonSerializer.Serialize(trida);
            File.WriteAllText("trida.json", jsonString);

            Console.WriteLine("Data byla úspěšně serializována do JSON souboru.");
        }
    }
}
