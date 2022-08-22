using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius;

            Console.WriteLine("Enter the Celsius value : ");
            celsius = Convert.ToInt32(Console.ReadLine());

            fahrenheit = (celsius * 9) / 5 + 32;

            Console.WriteLine("Fahrenheit : {0}", fahrenheit);

            Console.ReadLine();
        }
    }
}
