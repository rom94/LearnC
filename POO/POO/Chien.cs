using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Chien : Animal
    {
        public string Prenom { get; set; }

        public virtual void Aboyer ()
        {
            Console.WriteLine("Wouaf !");
        }

        public void Vieillir ()
        {
            age++;
        }

        public void Naissance ()
        {
            age = 0;
            estVivant = true;
        }

        /*public Chien (string prenomDuChien)
            : base(prenomDuChien)
        {
        }*/

        public override string ToString ()
        {
            return "Je suis un chien et je m'appelle " + Prenom;
        }

        public override void SeDeplacer ()
        {
            Console.WriteLine("Waouf ! Je me déplace avec mes 4 pattes");
        }
    }
}
