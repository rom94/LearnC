using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu
{
    class BossDeFin
    {
        public int PtsDeVie { get; private set; }
        public bool EstVivant
        {
            get { return PtsDeVie > 0; }
        }

        public BossDeFin (int points)
        {
            PtsDeVie = points;
        }

        public void Attaque (Joueur personnage)
        {
            int nbPoints = LanceLeDe(26);
            personnage.SubitDegats(nbPoints);
        }

        public void SubitDegats (int valeur)
        {
            PtsDeVie -= valeur;
        }

        private int LanceLeDe (int valeur)
        {
            return De.LancerLeDe(valeur);
        }
    }
}
