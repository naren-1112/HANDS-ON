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
            int i, n;
            int[] a = new int[100];

         

            Console.Write("Enter the number of elements :");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter {0} number of elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element --> {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values in the array are : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }

            Console.Write("\n\nThe values in reverse are :\n");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.ReadLine();
        }
    }
    }
