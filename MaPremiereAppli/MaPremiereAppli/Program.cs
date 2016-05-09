using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremiereAppli
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int age = 30;
            Console.WriteLine(age);
            int age1 = 20;
            int moyenneAge = (age + age1) / 2;
            Console.WriteLine(moyenneAge);
            string firstName = "Romain";
            Console.WriteLine(firstName);
            decimal compte = 100;
            Console.WriteLine(compte);
            bool isTrue = true;
            Console.WriteLine(isTrue);
            Console.WriteLine(firstName + " a " + age + " ans.");
            string phrase = "Salut, je m'appel \"Romain\"";
            Console.WriteLine(phrase);
            string fichier = @"c:\file\file\file.cs";
            Console.WriteLine(fichier);
            Console.WriteLine("Passer" + Environment.NewLine + "ligne");*/

            /*int compte = -300;
            bool isCrediteur = compte >= 0;
            if (isCrediteur)
                Console.WriteLine(compte + " : Compte créditeur");
            else
                Console.WriteLine(compte + " : Compte débiteur");*/

            /*string login = "Nicolas";
            string pass = "test";
            if (login == "Nicolas" && pass == "test")
                Console.WriteLine("Bienvenue Nicolas !");
            else
                Console.WriteLine("Login ou mot de passe incorrect");*/

            /*string civilite = "Mlle";
            if (civilite == "Mme" || civilite == "Mlle")
                Console.WriteLine("Vous êtes une femme");
            else
                Console.WriteLine("Vous êtes un homme");*/

            /*string civilite = "Mlle";
            switch (civilite) {
                case "M." :
                    Console.WriteLine("Bonjour Monsieur");
                    break;
                case "Mme" :
                    Console.WriteLine("Bonjour Madame");
                    break;
                case "Mlle" :
                    Console.WriteLine("Bonjour Mademoiselle");
                    break;
            }*/
            
            /*DireBonjour("Romain", 27);
            DireBonjour("Nicolas", 18);*/

            //Console.WriteLine("Le résultat est : " + CalculHypo(10,10));

            /*Bonjour("inconnu");
            Bonjour("Romain");*/

            /*string[] jours = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            Array.Sort(jours);
            for (int i = 0; i < jours.Length; i++)
            {
                Console.WriteLine(jours[i]);
            }*/

            /*List<int> chiffres = new List<int> ();
            chiffres.Add(8);
            chiffres.Add(9);
            chiffres.Add(4);

            chiffres.RemoveAt(1);
            foreach (int chiffre in chiffres) {
                Console.WriteLine(chiffre);
            }*/

            /*List<string> chaines = new List<string>();
            chaines.Add("lundi");
            chaines.Add("mardi");
            chaines.Add("mercredi");
            chaines.Add("jeudi");
            chaines.Add("vendredi");
            chaines.Add("samedi");
            chaines.Add("dimanche");

            int indice = chaines.IndexOf("mardi");
            Console.WriteLine(indice);*/

            /*Jours lundi = Jours.Lundi;
            Console.WriteLine(lundi);*/

            /*Console.WriteLine(DateTime.Now);
            Console.WriteLine(Environment.UserName);*/

            /*int compteur;
            for (compteur = 0; compteur < 5; compteur++)
            {
                Console.WriteLine("Salut " + compteur);
            }*/

            /*string[] jours = new string[] {"Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            int indice;
            for (indice = 0; indice < jours.Length; indice++)
            {
                Console.WriteLine(jours[indice]);
            }*/

            /*string[] jours = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"};
            int i = 0;
            bool trouve = false;
            while (i < jours.Length && !trouve)
            {
                string valeur = jours[i];
                if (valeur == "Mardi")
                {
                    trouve = true;
                }
                else
                {
                    i++;
                }
            }
            if (!trouve)
                Console.WriteLine("Valeur non trouvé");
            else
                Console.WriteLine("Trouvé à l'indice " + i);*/

        }

        /*private static void DireBonjour (string prenom, int age)
        {
            Console.WriteLine("Bonjour " + prenom);
            Console.WriteLine("Tu as " + age + " ans");
        }*/

        /*private static double CalculHypo (double a, double b) {
            double sommeDesCarre = a * a + b * b;
            double resultat = Math.Sqrt(sommeDesCarre);
            return resultat;
        }*/

        /*static void Bonjour(string prenom) {
            if (prenom == "inconnu")
                return;
            Console.WriteLine("Bonjour "+ prenom);
        }*/

        /*enum Jours
        {
            Lundi = 5,
            Mardi,
            Mercredi = 11,
            Jeudi,
            Vendredi,
            Samedi = 15,
            Dimanche,
        }*/
    }
}
