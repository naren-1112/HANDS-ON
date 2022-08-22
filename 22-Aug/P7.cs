using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    class P7
    {
        static void Main(string[] args)
        {
            Queue<int> s = new Queue<int>();
            s.Enqueue(1);
            s.Enqueue(11);
            s.Enqueue(111);
            s.Enqueue(1111);
            s.Enqueue(11111);
            foreach (var element in s)
            {
                Console.WriteLine(element);

            }
            Console.WriteLine("Total count :" + s.Count);
            s.Dequeue();
            Console.WriteLine("Count after performing Dequeue :" + s.Count);
            Console.WriteLine("Top most element is: " + s.Peek());
            Console.ReadLine();
        }
    }
}
