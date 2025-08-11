using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n   ARRAYS :");

            Console.WriteLine("\n  Single Dimensional:");
            string[] students = { "Huma ", "Hassan ", "Bilal " };
            //Console.WriteLine(students);
            foreach(string stds in students)
            {
                Console.Write(stds);
            }


            Console.WriteLine("\n\n  Multi Dimensional:");
            string[,] std = new string[2, 3];    //2columns, 3rows
            std[0, 0] = "Huma";
            std[1, 0] = "Hassan";

            std[0, 1] = "Bilal";
            std[1, 1] = "Kiran";

            std[0, 2] = "Rafay";
            std[1, 2] = "Aliza";
            //Console.WriteLine(std[0,2]);
            Console.WriteLine("The length of this array is " + std.Length);

            for(int i = 0; i <= 1; i++)
            {
                Console.WriteLine("---------------");
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write(j);
                    Console.WriteLine(std[i,j]);
                }
            }


            Console.WriteLine("\n\n  Jagged Array:");   //rows, columns
            string[][] users = new string[][]
            {
                new string[] {"Huma ","Bilal ", "Kiran "},
                new string[] {"Laiba "},
                new string[] {"Rafay ", "Erum "},
                new string[] {"Hassan ", "Anum ", "Noor"}
            };
            Console.WriteLine(users[3][1]);
            Console.WriteLine(users[2][0]);
            

            Console.ReadKey();
        }
    }
}
