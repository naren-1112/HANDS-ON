using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{n} {n} {n} {n}");
                Console.WriteLine($"{n}{n}{n}{n}");
                Console.ReadLine();
            }
        }
    }

}
