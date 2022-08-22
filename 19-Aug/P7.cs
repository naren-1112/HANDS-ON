using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the First subject mark:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second subject mark:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third subject mark:");
            c = Convert.ToInt32(Console.ReadLine());
            int Totalmark = a + b + c;
            Console.WriteLine("total_marks=" + " " + Totalmark);
            float per = Totalmark / 3;
            if (per < 35)
            {
                Console.WriteLine("fail");
                Console.ReadLine();
            }
            else if (per > 35 && per < 45)
            {
                Console.WriteLine("Third ");
                Console.ReadLine();
            }
            else if (per > 45 && per < 60)
            {
                Console.WriteLine("Second ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("First");
            }
            Console.ReadLine();
        }
    }
}
