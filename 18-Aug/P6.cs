using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"You look older than {x}");
            Console.ReadLine();
        }
    }
}
