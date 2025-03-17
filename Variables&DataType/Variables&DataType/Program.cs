using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Batch Code: ");
            string batchcode = Console.ReadLine();

            Console.WriteLine("Enter Your Email: ");
            string email = Console.ReadLine();

            Console.WriteLine($"{name} is from ");
            Console.WriteLine($"{batchcode} ");
            Console.WriteLine($"and email is {email}");

            Console.ReadKey();
        }
    }
}
