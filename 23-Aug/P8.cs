using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8
{
    class P8
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter First Number");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                int j = Convert.ToInt32(Console.ReadLine());
                int k = i / j;
                Console.WriteLine(k);


            }
            catch (DivideByZeroException E)
            {
                Console.WriteLine("This is Divide By Zero Exception");
                Console.WriteLine(E.Message);

            }
            catch (StackOverflowException E)
            {
                Console.WriteLine(E.Message);

            }
            finally
            {
                Console.WriteLine("Printed");

            }
            Console.ReadLine();
        }
    }
}
