using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    class P6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Department of Purchase: " + (int)deptnames.purchase);
            Console.WriteLine("Department of Sales: " + (int)deptnames.sales);
            Console.WriteLine("Department of Training: " + (int)deptnames.training);
            Console.WriteLine("Department of Account: " + (int)deptnames.account);

            Console.ReadLine();
        }
        enum deptnames
        {
            purchase = 1,
            sales,
            training,
            account
        }
    }
}
