using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu
{
    class Program
    {
        private static Random random = new Random();

        static void Main (string[] args)
        {
            AfficheMenu();
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
            while (consoleKeyInfo.Key != ConsoleKey.D1 && consoleKeyInfo.Key != ConsoleKey.D2 && consoleKeyInfo.Key != ConsoleKey.NumPad1 && consoleKeyInfo.Key != ConsoleKey.NumPad2)
            {
                AfficheMenu();
                consoleKeyInfo = Console.ReadKey(true);
            }

            if (consoleKeyInfo.Key == ConsoleKey.D1 || consoleKeyInfo.Key == ConsoleKey.NumPad1)
            {
                Jeu1();
            }
            else
            {
                Jeu2();
            }
        }

        private static void Jeu1 ()
        {
            Joueur romain = new Joueur(150);
            int cptFacile = 0;
            int cptDifficile = 0;

            while (romain.EstVivant)
            {
                MonstreFacile monstre = FabriqueDeMonstre();
                while (monstre.EstVivant && romain.EstVivant)
                {
                    romain.Attaque(monstre);
                    if (monstre.EstVivant)
                    {
                        monstre.Attaque(romain);
                    }
                }

                if (romain.EstVivant)
                {
                    if (monstre is MonstreDifficile)
                    {
                        cptDifficile++;
                    }
                    else
                    {
                        cptFacile++;
                    }
                }
                else
                {
                    Console.WriteLine("Snif, vous êtes mort ...");
                    break;
                }
            }

            Console.WriteLine("Bravo !!! Vous avez tué {0} monstres faciles et {1} monstres difficiles. Vous avez {2} points.", cptFacile, cptDifficile, cptFacile + cptDifficile * 2);
        }

        private static MonstreFacile FabriqueDeMonstre ()
        {
            if (random.Next(2) == 0)
            {
                return new MonstreFacile();
            }
            else
            {
                return new MonstreDifficile();
            }
        }

        private static void AfficheMenu ()
        {
            Console.Clear();
            Console.WriteLine("Veuillez choisir votre mode de jeu :");
            Console.WriteLine("\t1 : Contre les monstres");
            Console.WriteLine("\t2 : Contre le boss de fin");
        }

        private static void Jeu2 ()
        {
            Joueur romain = new Joueur(150);
            BossDeFin boss = new BossDeFin(250);

            while (romain.EstVivant && boss.EstVivant)
            {
                romain.Attaque(boss);
                if (boss.EstVivant)
                {
                    boss.Attaque(romain);
                }
            }

            if (romain.EstVivant)
            {
                Console.WriteLine("Bravo vous avez battu le boss");
            }
            else
            {
                Console.WriteLine("Game over");
            }
        }
    }
}
