using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirageLoto
{
    class Program
    {
        static void Main (string[] args)
        {
            TirageLoto();
        }

        private static void TirageLoto ()
        {
            int[] tirage = new int[7]; //Initialisation de mon tableau

            Random random = new Random();

            for (int i = 0; i < tirage.Length; i++)
            {
                int numero;

                do
                {
                    numero = random.Next(1, 49);

                } while (tirage.Contains(numero));

                tirage[i] = numero;

                Console.WriteLine(tirage[i]);
            }
        }
    }
}
