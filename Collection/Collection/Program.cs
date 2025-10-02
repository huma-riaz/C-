using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n COLLECTIONS :");



            // NON GENERICS COLLECTION : 
            //kisi bhi type ka data aaa skta hai...
            Console.WriteLine("\n\n NON GENERICS :");

            var list = new ArrayList();
            list.Add("Huma Riaz");
            list.Add(19);
            list.Add(20.5);
            list.Add(true);

            foreach(var data in list)
            {
                Console.WriteLine(data);
            }



            Console.WriteLine("\n NON GENERICS WITH HASHTABLE :");
            // NON GENERIC: HASHTABLE : 
            // is mai key values hoti hn jo data ko fast search krwati hn...

            var mylist = new Hashtable();
            mylist.Add("Name", "Huma Riaz");
            mylist.Add("Age", 19);
            mylist.Add("Gender", "Girl");

         // Console.WriteLine(mylist["Gender"]);
        // DictionaryEntry value aur key dono ko print krwane k liye use krty hn...   
            foreach (DictionaryEntry item in mylist)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }



            Console.WriteLine("\n\n GENERICS :");
            // Ye safe type hoti hai, jo key do gy usi type mai value dyni hogi...

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Age", 7);
            dict.Add("Year", 5);
            //Console.WriteLine(dict["Year"]);

            foreach(var newitem in dict)
            {
                Console.WriteLine(newitem.Key + " : " + newitem.Value);
            }



            Console.WriteLine("\n\n QUEUE :");    // FIFO
            Queue<string> colors = new Queue<string>();
            colors.Enqueue("Red");
            colors.Enqueue("Yellow");
            colors.Enqueue("Orange");

            foreach( var queprint in colors)
            {
                Console.WriteLine(queprint);
            }
            Console.WriteLine("-------------");
            Console.WriteLine(colors.Dequeue());



            Console.WriteLine("\n\n  STACK :");    // LIFO
            Stack<string> fruits = new Stack<string>();
            fruits.Push("Apple");
            fruits.Push("Mango");
            fruits.Push("Banana");

            foreach( var staprint in fruits)
            {
                Console.WriteLine(staprint);
            }
            Console.WriteLine("-------------");
            Console.WriteLine(fruits.Pop());



            Console.ReadKey();

        }
    }
}
