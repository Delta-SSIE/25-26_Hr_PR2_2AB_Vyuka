using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace serializaceJson
{
    public class Student
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public List<int> Znamky = new List<int>();

         public void setJmeno(String jmeno)
           {
               this.Jmeno = jmeno;
           }
           public String getJmeno()
           {
               return this.Jmeno;
           }


           public void setPrijmeni(String prijmeni)
           {
               this.Prijmeni = prijmeni;
           }

           public String getPrijmeni()
           {
               return this.Prijmeni;
           }

           public void setZnamka(int znamka)
           {
               this.Znamky.Add(znamka);
           }
           
    }

}
