using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;

            Console.Write("Numbers between 100 and 200 : \n");
            for (i = 101; i < 200; i++)
            
                {
                    Console.Write("{0}  ", i);
                    sum += i;
                }
           
            Console.Write("\n\nThe sum : {0} \n", sum);
            Console.ReadLine();
        }
    }
}
