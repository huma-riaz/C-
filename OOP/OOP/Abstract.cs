using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Animal
    {
        public void sound()
        {
            Console.WriteLine("Animal Sound ");
        }

        public abstract void eat();
    }

    class Goat : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Goat eats grass ");
        }
    }

    class Monkey : Goat
    {
        public override void eat()
        {
            Console.WriteLine("Monkey eats banana ");
        }
    }
}
