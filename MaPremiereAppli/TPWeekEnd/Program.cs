using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWeekEnd
{
    class Program
    {
        static void Main (string[] args)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                AfficherBonWeekend();
            }
            else
            {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour < 9)
                {
                    AfficherBonWeekend();
                }
                else
                {
                    if (DateTime.Now.Hour >= 18 && DateTime.Now.DayOfWeek == DayOfWeek.Friday)
                        {
                            AfficherBonWeekend();
                        }
                    
                    else
                    {
                        if (DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 18)
                        {
                            AfficherBonneJournee();
                        }
                        else
                        {
                            AfficherBonneSoiree();
                        }
                    }
                }
            }
            Console.ReadKey(); //Permet de bloquer la fenêtre (attente de l'appui d'une touche)
        }

        private static void AfficherBonWeekend ()
        {
            Console.WriteLine("Bon week-end " + Environment.UserName);
        }

        private static void AfficherBonneJournee ()
        {
            Console.WriteLine("Bonjour " + Environment.UserName);
        }

        private static void AfficherBonneSoiree ()
        {
            Console.WriteLine("Bonsoir " + Environment.UserName);
        }
    }
}