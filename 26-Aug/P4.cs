using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class P4
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("Hey");
            list.AddLast("h");
            list.AddBefore(list.Last, "go");
            list.AddAfter(list.First, "come");
            list.AddBefore(list.Last.Previous, "welcome");
            list.AddAfter(list.First.Next, "not now");
            LinkedListNode<string> foundnode = list.Find("go");
            foundnode.Value = "done";
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
