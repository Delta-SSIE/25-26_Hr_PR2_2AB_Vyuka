using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani24_10
{
    internal class Auto : Barvicka, IDoprava, IPopis
    {
        public void NapisNazev()
        {
            throw new NotImplementedException();
        }

        public void Pohyb()
        {
            Console.WriteLine("Jedu");
        }

        public void ZastavSe()
        {
            Console.WriteLine("Stojim");
        }

        public override void napisBarvu()
        {
            Console.WriteLine("barva moje");
        }

    }
}
