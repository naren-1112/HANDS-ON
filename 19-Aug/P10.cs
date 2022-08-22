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
            int n, k, sum = 0, i;

            Console.Write("\n\n");
            Console.Write("Display the number in reverse order:\n");
            Console.Write("--------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = n; i != 0; i = i / 10)
            {
                k = i % 10;
                sum = sum * 10 + k;
            }
            Console.Write("The number in reverse order is : {0} \n", sum);
            Console.ReadLine();
        }
    }
}
