using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3;

            Console.WriteLine("Enter the first number : ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            n3 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                //4
                if (n1 > n3)
                {
                    Console.WriteLine("largest number : " + n1);
                }
                else
                {
                    Console.WriteLine("largest number : " + n3);
                }
            }
            else
            {
                if (n2 > n3)
                {
                    Console.WriteLine("largest number : " + n2);
                }
                else
                {
                    Console.WriteLine("largest number : " + n3);
             
                }

                Console.ReadLine();
            }
        }
    }
}
        