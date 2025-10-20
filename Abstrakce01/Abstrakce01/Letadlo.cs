using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakce01
{
    internal class Letadlo:Doprava
    {
        public Letadlo(string barva, int rychlost)
               : base(barva, rychlost) { }

        // Přepsání metody Pohyb
        public override void Pohyb()
        {
            Console.WriteLine($"Letadlo barvy {Barva} letí rychlostí {Rychlost} km/h.");
        }
    }
}
