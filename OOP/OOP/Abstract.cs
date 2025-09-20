using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    //Iski body nhi hoti lekin child class mai zaroor complete kia jata hai...
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

   //  INTERFACE : is mai method/properties k sirf name hoty hn, body nhi
   //  lekin interface ko implement kr k method ko override krty hn

    public interface IAnimal
    {
         void Isound();
    }
    public class Icat : IAnimal
    {
        public void Isound()
        {
            Console.WriteLine("Cat drinks milk.");
        }
    }


}
