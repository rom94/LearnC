using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculsEnBoucle
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine(CalculSommeEntier(1, 20));
            Console.WriteLine(CalculSommeEntier(1, 100));

            List<double> liste = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6 };
            Console.WriteLine(CalculMoyenne(liste));

            Console.WriteLine(CalculSommeIntersection());
        }

        static int CalculSommeEntier (int bornMin, int bornMax)
        {
            int resultat = 0;
            for (int i = bornMin; i <= bornMax; i++)
            {
                if (i % 5 == 0)
                {
                    resultat += i;
                }
            }
            return resultat;
        }

        static double CalculMoyenne (List<double> liste)
        {
            double somme = 0;
            foreach (double valeur in liste)
            {
                somme += valeur;
            }
            return somme / liste.Count;
        }

        static int CalculSommeIntersection ()
        {
            List<int> multiple3 = new List<int>();
            List<int> multiple5 = new List<int>();

            for (int i = 3; i <= 100; i += 3)
            {
                multiple3.Add(i);
            }

            for (int i = 5; i <= 100; i += 5)
            {
                multiple5.Add(i);
            }

            int somme = 0;
            foreach (int m3 in multiple3)
            {
                foreach (int m5 in multiple5)
                {
                    if (m3 == m5)
                    {
                        somme += m3;
                    }
                }
            }

            return somme;
        }
    }
}
