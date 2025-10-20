using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedicnostUvod2
{
    internal class Osoba
    {
        private string jmeno;
        protected void setJmeno (string jmeno)
        {
            this.jmeno = jmeno;
        }

        public string getJmeno() { 
        return this.jmeno;
        }

        public void PredstavSe ()
        {
          Console.WriteLine("Ahoj me jmeno je: " + this.jmeno);  
        }
    }
}
