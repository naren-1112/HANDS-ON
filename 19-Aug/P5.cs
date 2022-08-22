using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("Enter 1st Number :");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd Number :");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("First number is greater than the second number");
            }
            else
            {
                Console.WriteLine("First number is smaller than the second number");
            }
            Console.ReadLine();
        }
    }
}
