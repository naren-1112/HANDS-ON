using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first integer: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Input second integer: ");
            int n2 = int.Parse(Console.ReadLine());

            //Check if one is negative and one is positive

            //bool result = (n2 < 0 && n1 >= 0) || (n1 < 0 && n2 >= 0);

            //Console.WriteLine($"Check if one is negative and one is positive: {result}");

            //Check if both are positive

            bool result = (n2 >= 0 && n1 >= 0) && (n1 >= 0 && n2 >= 0);

            Console.WriteLine($"Check if both are positive: {result}");

            Console.ReadLine();
        }
    }
}
