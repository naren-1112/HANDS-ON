using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1, j = 25; i <= j; i++, j--)
            {
                Console.WriteLine("i ={0} and j = {1}", i, j);
            }
            Console.WriteLine("Crossed Over");
            Console.ReadLine();
        }
    }
}
