using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
  //  Aik he class different namespace mai...
    class Student
    {
        public void sname1()
        {
            Console.WriteLine("First Namespace ");
        }

    }
}

namespace namespace2
{
    class Student
    {
        public void sname2()
        {
            Console.WriteLine("Second Namespace ");
        }
    }
    
}
