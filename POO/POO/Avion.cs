using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Avion : IVolantMotorise
    {
        public int NombrePropulseurs { get; set; }
        public string NomDuCommandant { get; set; }

        public void DemarrerLeMoteur ()
        {
        }

        public void Voler ()
        {
            Console.WriteLine("Je vole grâce à " + NombrePropulseurs + " moteurs");
        }
    }
}
