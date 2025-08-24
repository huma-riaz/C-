using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat mycat = new Cat();
            mycat.name = "Mano ";
            mycat.sound = "Meoww Meoww";
            mycat.Details();


            Console.ReadKey();
        }
    }

    class Animal
    {
        public string name;
        public string sound;
    }
    class Dog : Animal
    {

    }
    class Cat : Dog
    {
        public void Details()
        {
            Console.WriteLine("Animal name is {0}, Sound is {1}", 
                            this.name,this.sound);
        }
    }


}
