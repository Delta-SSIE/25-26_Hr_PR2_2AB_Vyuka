using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedicnostUvod
{
    internal class Osoba
    {
        private string jmeno;

        public string Jmeno { get => jmeno; set => jmeno = value; }
        public int Vek { get => vek; set => vek = value; }

        private int vek;
        public void Pozdrav()
        {
            Console.WriteLine("Ahooooj tady " + this.jmeno);
        }


    }
}
