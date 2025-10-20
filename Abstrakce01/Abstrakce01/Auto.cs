using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakce01
{
    internal class Auto:Doprava
    {
        public Auto(string barva, int rychlost)
           : base(barva, rychlost) { }

        // Přepsání metody Pohyb
        public override void Pohyb()
        {
            Console.WriteLine($"Auto barvy {Barva} jede rychlostí {Rychlost} km/h.");
        }
    }
}
