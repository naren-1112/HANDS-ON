using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10
{
    class P10
    {
        static void Main(string[] args)
        {
            SortedList<int, string> dct = new SortedList<int, string>();
            dct.Add(1, "appnet");
            dct.Add(2, "ab.net");
            dct.Add(3, "pc.net");
            dct.Add(4, "vb.net");
            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            dct.Remove(2);
            Console.WriteLine("after removing");
            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            Console.ReadLine();
        }
    }
}
