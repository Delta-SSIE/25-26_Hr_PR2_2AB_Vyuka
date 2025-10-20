using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani
{
    internal class Notebook : IZarizeni
    {
        public void Vypnout()
        {
            Console.WriteLine("vypnuto");
        }

        public void Zapnout()
        {
            Console.WriteLine("zapnuta");
        }
    }
}
