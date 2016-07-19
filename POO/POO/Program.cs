using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main (string[] args)
        {
            /*Voiture voitureRomain = new Voiture();
            //voitureRomain.Klaxonner();
            voitureRomain.Rouler();

            Voiture voitureBenj = new Voiture(80);
            voitureBenj.Rouler();*/

            /*Animal animal = new Animal { NombreDePattes = 4 };
            animal.Respirer();
            Console.WriteLine();

            Chien chien = new Chien { NombreDePattes = 4 };
            chien.Respirer();
            chien.Aboyer();*/

            /*List<Animal> animaux = new List<Animal>();
            Animal milou = new Chien("Milou");
            Animal idefix = new Chien("Idéfix");
            Animal dingo = new Chien("Dingo");
            Animal tom = new Chat("Tom");
            Animal felix = new Chat("Félix");

            animaux.Add(milou);
            animaux.Add(idefix);
            animaux.Add(dingo);
            animaux.Add(tom);
            animaux.Add(felix);

            foreach (Animal animal in animaux)
            {
                animal.Respirer();
            }*/

            //Chien chien = new Chien { Prenom = "Max" };
            //Console.WriteLine(chien.ToString());

            /*ChienMuet chienMuet = new ChienMuet();
            chienMuet.Aboyer();*/


            //List<Animal> animaux = new List<Animal>();
            //Chien chien = new Chien();
            //Chat chat = new Chat();

            //animaux.Add(chien);
            //animaux.Add(chat);

            //foreach (Animal animal in animaux)
            //{
            //    if (animal is Chien)
            //    {
            //        Chien c = (Chien)animal;
            //        c.Aboyer();
            //    }
            //    if (animal is Chat)
            //    {
            //        Chat c = (Chat)animal;
            //        c.Miauler();
            //    }
            //}

            //foreach (Animal animal in animaux)
            //{
            //    Chien c1 = animal as Chien;
            //    if (c1 != null)
            //    {
            //        c1.Aboyer();
            //    }
            //    Chat c2 = animal as Chat;
            //    if (c2 != null)
            //    {
            //        c2.Miauler();
            //    }
            //}

            //Voiture voitureNicolas = new Voiture();
            //voitureNicolas.Couleur = "Bleue";
            //Voiture voitureJeremie = voitureNicolas;
            //voitureJeremie.Couleur = "Verte";
            //if (voitureJeremie == voitureNicolas)
            //{
            //    Console.WriteLine("Les objets référencent la même instance");
            //}

            //Voiture voitureNicolas = new Voiture { Vitesse = 10, Marque = "Peugeot", Couleur = "Grise" };
            //Voiture voitureJeremie = new Voiture { Vitesse = 10, Marque = "Peugeot", Couleur = "Grise" };

            //if (voitureNicolas.Equals(voitureJeremie))
            //{
            //    Console.WriteLine("Les objets ont les même valeurs dans leur propriétés");
            //}

            //Voiture[] voitures = new Voiture[] { new Voiture { Vitesse = 100 }, 
            //new Voiture { Vitesse = 40 },
            //new Voiture { Vitesse = 10 }, 
            //new Voiture { Vitesse = 40 },
            //new Voiture { Vitesse = 50 } };
            //Array.Sort(voitures);
            //foreach (Voiture v in voitures)
            //{
            //    Console.WriteLine(v.Vitesse);
            //}

            //Oiseau oiseau = new Oiseau { NombrePropulseurs = 2 };
            //Avion avion = new Avion { NombrePropulseurs = 4, NomDuCommandant = "Romain" };

            //List<IVolant> volants = new List<IVolant> { oiseau, avion };
            //foreach (IVolant volant in volants)
            //{
            //    volant.Voler();
            //    Avion a = volant as Avion;
            //    if (a != null)
            //    {
            //        Console.WriteLine(a.NomDuCommandant);
            //    }
            //}

            Chien max = new Chien();
            max.SeDeplacer();
            max.Mourir();
        }
    }
}
