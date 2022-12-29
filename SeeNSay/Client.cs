using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeNSay
{
    internal class Client
    {


        private static Donkey donkey;
        private static Pig pig;
        private static Cow cow;
      

        static void Main(string[] args)
        {
            Console.WriteLine("starting...");
            
            donkey = new Donkey();
            donkey.speak();

            pig= new Pig();
            pig.speak();

            cow = new Cow();
            cow.speak();    

            new Client().doStuff();
        }

        void doStuff()
        {
            Pig pig2 = new Pig();   
            pig2.speak();
        }
    }
}
