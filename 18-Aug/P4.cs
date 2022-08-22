using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4;

            Console.Write("Enter the First number: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            double Average = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
         n1, n2, n3, n4, Average);
            Console.ReadLine();
        }
    }
}
