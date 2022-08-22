using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList A = new ArrayList { 5 };
            A.Add(43);
            A.Add(12);
            A.Add(22);
            A.Add(96);
            A.Add(88);
            Console.WriteLine("Count {0}", A.Count);
            A.Remove(43);
            Console.WriteLine("Remove {0}", A.Count);
            Console.ReadLine();
        }
    }
}
