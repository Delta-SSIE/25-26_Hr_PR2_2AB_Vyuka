using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani
{
    internal class Mobil : IZarizeni
    {
        public void Vypnout()
        {
            Console.WriteLine("Mobil vypnut.");
        }

        public void Zapnout()
        {
            Console.WriteLine("Mobil zapnut.");
        }
    }
}
