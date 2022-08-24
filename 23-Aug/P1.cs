using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class P1
    {
        static void Main(string[] args)
        {
            Add nos = new Add();

            nos.sum(50, 20);
        }
    }
    class Add
    {
        public void sum(int a, int b)
        {
            Console.WriteLine("SUM = " + (a + b));
            Console.ReadLine();
        }
    }
}
