using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollar = 0;
            double rupee = 0;
            double value = 0;

            Console.Write("Enter amount in USD: ");
            dollar = double.Parse(Console.ReadLine());

            Console.Write("Enter the USD value :");
            value = double.Parse(Console.ReadLine());

            rupee = dollar * value;
            Console.WriteLine("USD " + dollar + "-> INR " + rupee);
            Console.ReadLine();
        }
    }
}
