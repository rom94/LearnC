using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu
{
    class Joueur
    {
        public int PtsDeVie { get; private set; }
        public bool EstVivant
        {
            get { return PtsDeVie > 0; }
        }

        public Joueur (int points)
        {
            PtsDeVie = points;
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

        public void Attaque (BossDeFin boss)
        {
            int nbPoints = LanceLeDe(26);
            boss.SubitDegats(nbPoints);
        }

        public int LanceLeDe ()
        {
            return De.LancerLeDe();
        }

        public int LanceLeDe (int valeur)
        {
            return De.LancerLeDe(valeur);
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
            return De.LancerLeDe() <= 2;
        }
    }
}
