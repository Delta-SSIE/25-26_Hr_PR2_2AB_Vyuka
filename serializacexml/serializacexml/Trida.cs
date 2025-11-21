using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializacexml
{
   public class Trida
    {
        public string Nazev;
        public void setNazev(String nazev)
        {
            this.Nazev = nazev;
        }

        public String getNazev()
        {
            return this.Nazev;
        }
        public List<Student> SeznamStudentu = new List<Student>();
        public void setStudent(Student s)
        {
            this.SeznamStudentu.Add(s);
        }

    }
}
