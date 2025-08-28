using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Many Types: 
    // Compile time polymorphism (same method, different parameters )
    class Calculator
    {
        public void calculate(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Calculate(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void Calculate(int a, int b, int c)
        {
            Console.WriteLine(a * b * c);
        }

    }


    // Run time polymorphism (Parent class ko override kr k child class apna behavior show krta hai)
    class Student
    {
        virtual public void name()
        {
            Console.WriteLine(" My name is Abdul Rafay");
        }
    }
    class std : Student
    {
        override public void name()
        {
            Console.WriteLine(" My name is Huma ");
        }
    }
    class newstd : Student
    {
        override public void name()
        {
            Console.WriteLine(" My name is Huma Riaz");
        }
    }

}
