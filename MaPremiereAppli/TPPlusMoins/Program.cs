using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPlusMoins
{
    class Program
    {
        static void Main (string[] args)
        {
            int valeurATrouver = new Random().Next(0, 101);
            int compteur = 0;
            bool trouve = false;

            Console.WriteLine("Veuillez saisir un nombre entre 0 et 100 : ");

            while (!trouve)
            {
                string saisie = Console.ReadLine();
                int valeurSaisie;

                if (int.TryParse(saisie, out valeurSaisie))
                {
                    if (valeurSaisie == valeurATrouver)
                    {
                        trouve = true;
                    }
                    else
                    {
                        if (valeurSaisie < valeurATrouver)
                        {
                            Console.WriteLine("Trop petit");
                        }
                        else
                        {
                            Console.WriteLine("Trop grand");
                        }
                    }
                    compteur++;
                }
                else
                {
                    Console.WriteLine("La valeur saisie est incorrecte, veuillez réessayer");
                }
            }
            Console.WriteLine("Vous avez trouvé en " + compteur + " coups !");
        }
    }
}
