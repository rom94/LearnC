using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Voiture : IComparable
    {
        public int Vitesse { get; set; }

        public String Couleur { get; set; }

        public String Marque { get; set; }

        //Constructeur
        public Voiture ()
        {
            Vitesse = 5;
        }

        //Constructeur avec param
        public Voiture (int vitesse)
        {
            Vitesse = vitesse;
        }

        public void Rouler ()
        {
            Console.WriteLine("Je roule à " + Vitesse + " km/h");
        }

        public bool vitesseAutorisee (int vitesse)
        {
            return vitesse <= 90;
        }

        public void Klaxonner ()
        {
            if (!vitesseAutorisee(60))
            {
                Console.WriteLine("Pouet !");
            }
        }

        public override bool Equals (object obj)
        {
            Voiture v = obj as Voiture;
            if (v == null)
            {
                return false;
            }
            return Vitesse == v.Vitesse && Couleur == v.Couleur && Marque == v.Marque;
        }

        public override int GetHashCode ()
        {
            return Couleur.GetHashCode() * Marque.GetHashCode() * Vitesse.GetHashCode();
        }

        public int CompareTo (object obj)
        {
            Voiture voiture = (Voiture)obj;
            return Vitesse.CompareTo(voiture.Vitesse);
        }
    }
}
