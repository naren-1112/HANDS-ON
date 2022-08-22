using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;

            Console.Write("Input the 1st string : ");
            str1 = Console.ReadLine();

            Console.Write("Input the 2nd string : ");
            str2 = Console.ReadLine();


            Console.WriteLine(str1 == str2);
            Console.ReadLine();
        }
    }
}
