using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu
{
    class MonstreFacile
    {
        private const int degats = 10;
        protected De de;
        public bool EstVivant { get; private set; }

        public MonstreFacile ()
        {
            de = new De();
            EstVivant = true;
        }

        public virtual void Attaque (Joueur joueur)
        {
            int lanceMonstre = LancerLeDe();
            int lanceJoueur = joueur.LanceLeDe();
            if (lanceMonstre > lanceJoueur)
            {
                joueur.SubitDegats(degats);
            }
        }

        public int LancerLeDe ()
        {
            return de.LancerLeDe();
        }

        public void SubitDegats ()
        {
            EstVivant = false;
        }
    }
}
