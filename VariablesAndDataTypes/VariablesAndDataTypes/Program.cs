using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES:
            string myname = "Huma Riaz ";
            int age = 19;
            double point = 4.6;
            bool check = true;
            float height = 5.4F;

            Console.WriteLine("\n   VARIABLES AND DATA TYPES");
            //CHECK DATATYPE:
            Console.Write(" Data Type of " + myname + "is ");
            Console.WriteLine(myname.GetType());

            Console.Write(" Data Type of " + age + " is ");
            Console.WriteLine(age.GetType());

            Console.Write(" Data Type of " + point + " is ");
            Console.WriteLine(point.GetType());

            Console.WriteLine(" Data Type of " + check + " is " + check.GetType());
            //Console.Write(check.GetType());

            Console.WriteLine(" Data Type of " + height + " is " + height.GetType());


            //KEYWORDS:
            Console.WriteLine("\n\n   SPECIAL KEYS");
            Console.WriteLine(" Huma is a \"good\" girl.");


            //ARRAY:
            Console.WriteLine("\n\n  IN ARRAY");
            Console.WriteLine("{0}is {1} years old and height is {2}",
                myname,age,height);


            //INPUT FROM USER:
            Console.WriteLine("\n\nCHECK INPUT TYPE");
            Console.Write("  Enter your Age ");
            var uage = int.Parse(Console.ReadLine());
            Console.WriteLine(uage.GetType());


            //DATE AND TIME:
            Console.WriteLine("\n\n  DATE AND TIME");
            var today = DateTime.Now; 
            Console.WriteLine(today);
            Console.WriteLine("Month and Date is : {0:m}", today);
            Console.WriteLine("Year is : {0:y}", today);
            Console.WriteLine("Day is : {0:ddd}", today);

            Console.ReadKey();
        }
    }
}
