
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, min, max;
            Console.Write("Enter 1st Number :");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd Number :");
            n2 = Convert.ToInt32(Console.ReadLine());

            if(n1>n2)
                max = n1;
            
             else
                    max = n2;
            if(n1<n2)
                min = n1;
                
            else
                    min = n2;

            Console.WriteLine("Minimum Number = {0}",min);
            Console.WriteLine("Maximum Number = {0}",max);
            Console.ReadLine();


        }
    }
}
