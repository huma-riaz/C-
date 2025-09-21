using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
  // Apne data ko aik function mai hide krta hai aur sirf important cheezain show krwata hai
  // class k variables ko private rkhty hn...
    class Encapsulation
    {
        private string Name;
        private int Age;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int age
        {
            get { return Age; }
            set { 
            if (value > 0)
                {
                    Age = value;
                }else
                {
                    Console.WriteLine("Enter valid nmbr ");
                }
            }
        }
    }
}
