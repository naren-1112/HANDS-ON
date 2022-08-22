using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1, c2;

            Console.WriteLine("Enter the first character : ");
            c1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the second character : ");
            c2 = Convert.ToChar(Console.ReadLine());

            if (c1 == c2)
                Console.WriteLine("Both characters are equal");
            else
                Console.WriteLine("Characters are not equal");
            Console.ReadLine();
        }
    }
}
