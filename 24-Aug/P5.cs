using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class P5
    {
        public static void upper()
        {
            String s = "humanity";

            String upper = s.ToUpper();
            Console.WriteLine($"Original String : {s}");
            Console.WriteLine($"Uppercase String : {upper}");
            Console.ReadLine();

        }
    }
}
