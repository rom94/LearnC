using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public abstract class Animal
    {
        protected bool estVivant;
        private Coeur coeur;
        public int age;
        //protected string prenom;

        public int NombreDePattes { get; set; }

        /*public void Respirer ()
        {
            Console.WriteLine("Je suis " + prenom + " et je respire");
        }*/

        /*public Animal (string prenomAnimal)
        {
            prenom = prenomAnimal;
        }*/

        public abstract void SeDeplacer ();

        public Animal ()
        {
            coeur = new Coeur();
        }

        public void Mourir ()
        {
            coeur.Stop();
        }

    }
}
