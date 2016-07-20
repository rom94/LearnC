using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu
{
    class Joueur
    {
        private De de;
        public int PtsDeVie { get; private set; }
        public bool EstVivant
        {
            get { return PtsDeVie > 0; }
        }

        public Joueur (int points)
        {
            PtsDeVie = points;
            de = new De();
        }

        public void Attaque (MonstreFacile monstre)
        {
            int lanceJoueur = LanceLeDe();
            int lanceMonstre = monstre.LancerLeDe();
            if (lanceJoueur >= lanceMonstre)
            {
                monstre.SubitDegats();
            }
        }

        public int LanceLeDe ()
        {
            return de.LancerLeDe();
        }

        public void SubitDegats (int degats)
        {
            if (!BouclierFonctionne())
            {
                PtsDeVie -= degats;
            }
        }

        private bool BouclierFonctionne ()
        {
            return de.LancerLeDe() <= 2;
        }
    }
}
