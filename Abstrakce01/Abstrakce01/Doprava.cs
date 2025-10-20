using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakce01
{
    
        abstract class Doprava
        {
            public string Barva { get; set; }
            public int Rychlost { get; set; }

           
            public Doprava(string barva, int rychlost)
            {
                Barva = barva;
                Rychlost = rychlost;
            }

            // Virtuální metoda Pohyb
            public virtual void Pohyb()
            {
                Console.WriteLine("Doprava se pohybuje.");
            }
        }
    }

