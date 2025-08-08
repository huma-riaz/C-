using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIrstFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
            string name = "Huma Riaz ";
            int id = 1552130;
            string batch = " PR2-202406E ";
            Console.WriteLine("NAME: " + name );
            Console.WriteLine("ID: " + id);
            Console.WriteLine("BATCH: " + batch);

            //INPUT Readline();
            Console.Write("First Value ");
            int value1 = int.Parse(Console.ReadLine());
            Console.Write("Second Value ");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Your answer is " + (value1 + value2));


            Console.ReadKey();
        }
    }
}
