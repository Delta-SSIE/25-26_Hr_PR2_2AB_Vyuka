using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializacexml
{
    public class Student
    {
        public string Jmeno;

        public void setJmeno(String jmeno)
        {
            this.Jmeno = jmeno;
        }
        public String getJmeno()
        {
            return this.Jmeno;
        }
        public string Prijmeni;

        public void setPrijmeni(String prijmeni)
        {
            this.Prijmeni = prijmeni;
        }

        public String getPrijmeni()
        {
            return this.Prijmeni;
        }
        public List<int> Znamky = new List<int>();
        public void setZnamka(int znamka)
        {
            this.Znamky.Add(znamka);
        }
    }
}
