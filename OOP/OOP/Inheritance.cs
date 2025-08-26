using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Animals     //Parent Class
    {
        public string name;
    }
    class Cat : Animals    //Child Class (Inherit)
    {
        public string sound;
        public void Details()
        {
            Console.WriteLine("Animal name is {0} And sound is {1}", this.name, this.sound);
        }
    }
    class Dog : Cat      //Multi Level Class
    {
        public void dogDetails()
        {
            Console.WriteLine("Animal name is {0} And sound is {1}", this.name, this.sound);
        }
    }




}
