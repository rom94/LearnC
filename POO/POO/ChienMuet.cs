using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    abstract class ChienMuet : Chien
    {
        public override void Aboyer ()
        {
            Console.WriteLine("...");
        }
    }
}
