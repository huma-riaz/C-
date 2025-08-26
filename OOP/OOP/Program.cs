using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object For Inheritance:
            Cat mycat = new Cat();
            mycat.name = "Mano";
            mycat.sound = "Meoww Meoww";
            mycat.Details();

            Dog mydog = new Dog();
            mydog.name = "Coco";
            mydog.sound = "Bhaoo Bhaaooo";
            mydog.dogDetails();


            Console.ReadKey();
        }
    }
}
