using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8
{
    class P8
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "Hey");
            h.Add(2, "Hearty");
            h.Add(3, "Welcome!!");

            Console.WriteLine("Before delete:");

            foreach (DictionaryEntry element in h)
            {
                Console.WriteLine("{0} and {1} ", element.Key, element.Value);
            }
            h.Remove(1);
            Console.WriteLine("After perform delete:");
            foreach (DictionaryEntry element in h)
            {
                Console.WriteLine("{0} and {1} ", element.Key, element.Value);
            }
            Console.ReadLine();
        }
    }
}
