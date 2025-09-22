using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n   NAMESPACE :");
            Student nstd1 = new Student();
            nstd1.sname1();

            namespace2.Student nstd2 = new namespace2.Student();
            nstd2.sname2();

            Console.WriteLine("\n\n   GENERIC CLASS :");
            Box<string> mybox = new Box<string>();
            mybox.Value = "Generic Class String Value ";
            Console.WriteLine(mybox.Value);

            Box<int> mybox2 = new Box<int>();
            mybox2.Value = 4589;
            Console.WriteLine(mybox2.Value);


            //  NON-GENERIC :
            Console.WriteLine("\n\n  NON-GENERIC CLASS :");

            var list = new ArrayList();
            list.Add("Huma Riaz ");
            list.Add("PR2-202406E");
            list.Add(20);
            list.Add(true);

            list.Remove(20);
            list.RemoveAt(1);
            list.Insert(1, "Bilal");

            foreach (var mylist in list)
            {
                Console.WriteLine(mylist);
            }



            Console.ReadKey();
        }
    }

}
