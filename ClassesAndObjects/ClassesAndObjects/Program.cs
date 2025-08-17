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
            Students std1 = new Students(1, "Huma", "06E");
            Students std2 = new Students(2, "Bilal", "snj");

            Console.ReadKey();
        }
    }

    class Students
    {
        public int id;
        public string name;
        public string batch;

        public Students(int stdid, string stdname, string stdbatch)
        {
            this.id = stdid;
            this.name = stdname;
            this.batch = stdbatch;

            Console.WriteLine("ID is {0} , Name is {1} And Batch is {2}",
                                 this.id,this.name,this.batch);
        }
    }

}
