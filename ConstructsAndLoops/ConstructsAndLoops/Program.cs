using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n   CONSTRUCTS :");
            Console.WriteLine("\n  If Construct:");
            int a = 5;
            if(a > 8)
            {
                Console.WriteLine(" It is greater than 8");
            }else
            {
                Console.WriteLine(" It is less than 8");
            }

            Console.WriteLine("\n Nested Construct:");
            bool check = false;
            string mood = "good";
            if(check)
            {
                if(mood == "good")
                {
                    Console.WriteLine(" Mood is good");
                }else
                {
                    Console.WriteLine(" Mood is not good");
                }
                //Console.WriteLine(" Your condition is true");
            }else
            {
                if (mood == "good")
                {
                    Console.WriteLine(" Mood is good");
                }
                else
                {
                    Console.WriteLine(" Mood is not good");
                }
                Console.WriteLine(" Your condition is false");
            }
            Console.WriteLine("------------------------");


            Console.WriteLine("\n  LOOP:");
            Console.WriteLine("\n\n FOR LOOP:");
            for(int i = 1; i < 5; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n\n WHILE LOOP:");
            int b = 5;
            while(b < 10)
            {
                Console.Write(b + " ");
                b++;
            }
            Console.WriteLine("\n\n DO-WHILE LOOP:");
            int c = 11;
            do
            {
                Console.Write(c + " ");
                c++;
            } while (c < 15);

            Console.WriteLine("\n -----------------------");

            Console.WriteLine("\n\n Switch Case :");
            string day = "monday";
            switch (day)
            {
                case "sunday":
                    Console.WriteLine("Today is Sunday");
                    break;
                case "monday":
                    Console.WriteLine("Today is Monday");
                    break;
                case "tuesday":
                    Console.WriteLine("Today is Tuesday");
                    break;
                case "wednesday":
                    Console.WriteLine("Today is Wednesday");
                    break;
                case "thursday":
                    Console.WriteLine("Today is Thursday");
                    break;
                case "friday":
                    Console.WriteLine("Today is Friday");
                    break;
                case "saturday":
                    Console.WriteLine("Today is Saturday");
                    break;
                default:
                    Console.WriteLine("Something Wrong");
                    break;
            }




            Console.ReadKey();
        }
    }
}
