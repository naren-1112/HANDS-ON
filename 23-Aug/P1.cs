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
            Add ex = new Add();

            ex.sum(50, 20);
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
