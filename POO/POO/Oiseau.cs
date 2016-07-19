using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Oiseau : IVolant
    {
        public int NombrePropulseurs { get; set; }

        public void Voler ()
        {
            Console.WriteLine("Je vole grâce à " + NombrePropulseurs + " ailes");
        }
    }
}
