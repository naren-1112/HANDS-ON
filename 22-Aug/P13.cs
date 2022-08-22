using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13
{
    class P13
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 5, 200, 22, 2244, 213, 111 };
            int r = 100;
            Console.WriteLine("Given Integer {0}: ", r);
            Console.WriteLine("Numbers larger than {0} = ", r);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > r)
                {
                    Console.WriteLine(arr[i]);
                    Console.ReadLine();
                }
            }
        }
    }
}
