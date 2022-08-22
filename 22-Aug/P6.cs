using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    class P6
    {
        static void Main(string[] args)
        {
            Stack a = new Stack();
            a.Push(1);
            a.Push(2);
            a.Push(3);
            Console.WriteLine("Before pop:");
            foreach (Object obj in a)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Before pop Count " + a.Count);
            a.Pop();
            Console.WriteLine("After pop:");
            foreach (Object obj in a)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Peek  " + a.Peek());
            Console.WriteLine("After pop Count: " + a.Count);
            Console.ReadLine();
        }
    }
}
