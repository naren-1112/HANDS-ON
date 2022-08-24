using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    class P7
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter  first number");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
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
                Console.WriteLine("Anyway Printed");

            }
            Console.ReadLine();
        }
    }
}
