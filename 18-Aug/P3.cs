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
            Console.Write("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition = {0} + {1} = {2}", n1, n2, n1 + n2);
            Console.WriteLine("Subtraction = {0} - {1} = {2}", n1, n2, n1 - n2);
            Console.WriteLine("Multiplication = {0} x {1} = {2}", n1, n2, n1 * n2);
            Console.WriteLine("Division = {0} / {1} = {2}", n1, n2, n1 / n2);
            Console.WriteLine("Mod = {0} mod {1} = {2}", n1, n2, n1 % n2);
            Console.ReadLine();
        }
    }
}
