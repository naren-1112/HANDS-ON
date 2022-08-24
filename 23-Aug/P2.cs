using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class P2
    {
        static void Main(string[] args)
        {
            Add nos = new Add();

            int result = nos.sum(50, 20);
            Console.WriteLine("SUM" + " " + result);
            Console.ReadLine();
        }
    }

    class Add
    {
        public int sum(int a, int b)
        {
            int c = a + b;
            return c;
           
        }
            
    }
   

}
    

