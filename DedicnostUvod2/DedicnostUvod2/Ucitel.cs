using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedicnostUvod2
{
    internal class Ucitel:Osoba
    {
        public Ucitel() {
            setJmeno("karel");
        }
        public void OpravTest()
        {
            Console.WriteLine("Opravuji test");
        }
    }
}
