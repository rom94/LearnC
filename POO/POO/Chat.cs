using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Chat : Animal
    {
        /*public Chat (string prenomDuChat)
            : base(prenomDuChat)
        {
        }*/

        public void Miauler ()
        {
            Console.WriteLine("Miaou !");
        }


        public override void SeDeplacer ()
        {
            throw new NotImplementedException();
        }
    }
}
