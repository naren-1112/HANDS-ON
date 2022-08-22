using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class P5
    {
        static void Main(string[] args)
        {
            int[][] classroom = new int[4][];
            classroom[0] = new int[] {12, 19, 21, 11 };
            classroom[1] = new int[] { 183, 365 };
            classroom[2] = new int[] { 96, 99, 987 };
            classroom[3] = new int[] { 0, 45, 67, 55, 90 };


            for (int i = 0; i < classroom.Length; i++)
            {


                System.Console.Write("student({0}): ", i);

                for (int j = 0; j < classroom[i].Length; j++)
                {


                    System.Console.Write("{0} ", classroom[i][j]);
                }
                System.Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
