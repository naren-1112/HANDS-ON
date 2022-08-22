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

            Console.Write("Enter a number 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter number 3: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            int result1;
            int result2;
            result1 = (n1 + n2)*n3;
            result2 = (n1 * n2) + (n2 * n3);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.ReadLine();
        
        }
    }
}
