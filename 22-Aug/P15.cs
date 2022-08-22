using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15
{
    class P15
    {
        public static void print1stRepeating(int[] arr)
        {
            int min = -1;

            HashSet<int> set = new HashSet<int>();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
               
                if (set.Contains(arr[i]))
                {
                    min = i;
                }

                else 
                {
                    set.Add(arr[i]);
                }

            }

           
            if (min != -1)
            {
                Console.WriteLine("The 1st repeating element is " + arr[min]);
            }
            else
            {
                Console.WriteLine("There are no repeating elements");
            }
            Console.ReadLine();

        }


        

        public static void Main(string[] args)
        {
            int[] arr = new int[] { 12,11, 7, 4, 3,11, 7 };
            print1stRepeating(arr);
        }
    }
}
