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
            int n;
            Console.WriteLine("enter the Number");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n == 0)
            {
                case true:
                    Console.WriteLine("Number is zero");
                    break;
                case false:
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Number is even");
                    }
                    else
                    {
                        Console.WriteLine("Number is odd");
                    }
                    Console.ReadLine();
                    break;
            }
        }
    }
}
