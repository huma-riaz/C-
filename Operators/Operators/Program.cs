using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n OPERATORS :");
            Console.WriteLine("\n Arithmetic Operators:");
            int val1 = 8;
            int val2 = 2;
            Console.WriteLine("In Addition : " + (val1+val2));
            Console.WriteLine("In Subtraction : " + (val1-val2));
            Console.WriteLine("In Multiplication : " + (val1*val2));
            Console.WriteLine("In Division : " + (val1/val2));


            Console.WriteLine("\n Comparision Operators:");
            int a = 10;
            int b = 20;
            int c = 10;
            Console.WriteLine("In Equal : " + (a == b));
            Console.WriteLine("Not Equal : " + (a != b));
            Console.WriteLine("In Greater : " + (a > b));
            Console.WriteLine("In Less : " + (a < b));
            Console.WriteLine("Greater than equal : " + (a >= c));
            Console.WriteLine("Less than equal : " + (a <= b));


            Console.WriteLine("\n Logical Operators:");
            Console.WriteLine("AND (both condition must be true)");
            Console.WriteLine("AND : " + (a == c & a > b));
            Console.WriteLine("AND : " + (a == c & a < b));
            Console.WriteLine("OR (only one condition true)");
            Console.WriteLine("OR : " + (a == c | a > b));
            Console.WriteLine("OR : " + (a == c | a < b));


            Console.WriteLine("\n Pre- Increment:");
            int e = 3;
            //pre mai phly value print hogi phr plus hoga
            Console.WriteLine("value of Pre-Increment is {0}", e++);
            Console.WriteLine("result is {0}" , e);

            //Post mai aik he step mai add ho k print hojaye ga
            Console.WriteLine("\n Post-Increment:");
            Console.WriteLine("value of Post-Increment is {0}", ++e);

            Console.WriteLine("\n Pre-Decrement:");
            Console.WriteLine("value of Pre-Decrement is {0}", e--);
            Console.WriteLine("result is {0}", e);

            Console.WriteLine("\n Post-Decrement:");
            Console.WriteLine("value of Post-Decrement is {0}", --e);


            Console.WriteLine("\n Compound Assignment Operators:");
            int value = 7;
            value += 5;
            Console.WriteLine("Result is {0}" , value);

            Console.WriteLine("---------------");
            int val = 16;
            val -= 8;
            Console.WriteLine("Result is {0}", val);


            Console.ReadKey();
        }
    }
}
