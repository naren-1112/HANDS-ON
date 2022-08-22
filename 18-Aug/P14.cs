using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello world!!";
            string s2 = "";
            bool b1 = string.IsNullOrEmpty(s1);
            Console.WriteLine(b1);
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}
