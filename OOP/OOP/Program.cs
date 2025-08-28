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
            Console.WriteLine("\n     OOP : Object Oriented Programming");
            Console.WriteLine("  OOP base on 4 pillars:");
            Console.WriteLine("  1_  Inheritance      2_  Polymorphism");
            Console.WriteLine("  3_  Encapsulation    4_  Abstract \n ");
            
            // Object For Inheritance:
            Console.WriteLine("\n  Inheritance :");

            Cat mycat = new Cat();
            mycat.name = "Mano";
            mycat.sound = "Meoww Meoww";
            mycat.Details();

            Dog mydog = new Dog();
            mydog.name = "Coco";
            mydog.sound = "Bhaoo Bhaaooo";
            mydog.dogDetails();


            // Object For Polymorphism:
            Console.WriteLine("\n\n  Polymorphism : (two types)");
            Console.WriteLine(" Compile Time (Overloading)");

            Calculator mycal = new Calculator();
            mycal.calculate( 5, 10);
            mycal.Calculate( 50, 25);   // same obj , diff parameters.
            mycal.Calculate( 2, 2, 2);

            Console.WriteLine(" Run Time (Overriding)");
            std mystd = new std();
            mystd.name();

            newstd stdd = new newstd();
            stdd.name();


            Console.ReadKey();
        }
    }
}
