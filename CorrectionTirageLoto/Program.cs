using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] tabLoto = new int[7];

			int i = 0;
			while (i < 7)
			{
				int nbAleatoire = new Random().Next(1, 50);
				if (!EstDejaPresent(tabLoto, i, nbAleatoire))
				{
					tabLoto[i] = nbAleatoire;
					i++;
				}
			}

			AfficheLeTableau(tabLoto);
		}

		private static bool EstDejaPresent(int[] tabLoto, int i, int nbAleatoire)
		{
			for (int j = 0; j < i; j++)
			{
				if (tabLoto[j] == nbAleatoire)
				{
					return true;
				}
			}
			return false;
		}

		private static void AfficheLeTableau(int[] tabLoto)
		{
			Console.Write("Tirage utilisateur : ");
			for (int k = 0; k < tabLoto.Length; k++)
			{
				Console.Write(tabLoto[k] + " ");
			}
			Console.WriteLine();
		}
	}
}
