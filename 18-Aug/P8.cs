using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n}{n}{n}");
            Console.WriteLine($"{n} {n}");
            Console.WriteLine($"{n} {n}");
            Console.WriteLine($"{n} {n}");
            Console.WriteLine($"{n}{n}{n}");
            Console.ReadLine();
        }
    }
}
