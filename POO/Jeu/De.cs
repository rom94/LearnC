using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu
{
    class De
    {
        private static Random random = new Random();

        public De ()
        {
            random = new Random();
        }

        public static int LancerLeDe ()
        {
            return random.Next(1, 7);
        }

        public static int LancerLeDe (int valeur)
        {
            return random.Next(1, valeur);
        }
    }
}
