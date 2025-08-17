using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n  OOP : Object Oriented Programming");
            Console.WriteLine("\n\n  Classes And Objects:");

            //OBJECTS
            Students std1 = new Students("Huma", "girl", 19);
            Students std2 = new Students("Bilal", "boy", 22);

            Console.ReadKey();
        }
    }

    class Students   //Class
    {                //Properties
        public string name;
        public string gender;
        public int age;

        public Students(string stdname, string stdgender, int stdage)
        {
            this.name = stdname;
            this.gender = stdgender;
            this.age = stdage;

            Console.WriteLine("{0} is a {1} And age is {2}",
                             this.name, this.gender,this.age);
        }

    }

}
