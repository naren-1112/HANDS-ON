
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
            string first_name;
            string last_name;
            Console.WriteLine("Enter the First Name");
            first_name = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            last_name = Console.ReadLine();
            if (first_name == "userid" && last_name == "password")
            {
                Console.WriteLine("user has succesfully login in");
                Console.WriteLine("welcome to my app");
            }
            else
            {
                Console.WriteLine("incorrect first_name and password");
            }
            Console.ReadLine();
        }
    }
}
