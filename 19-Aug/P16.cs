using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 100;
            string input;
            Console.WriteLine("enter the input (Hit or Miss)");
            for (int i = 0; i <= 3; i++)
            {
                input = Console.ReadLine();
                if (input == "hit")
                {
                    score += 10;
                }
                else if (input == "miss")
                {
                    score -= 20;
                }
            }
            Console.WriteLine(score);
            Console.ReadLine();
        }
    }
}
