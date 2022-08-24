using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class P1
    {
        public static void cmp()
        {
            string s1 = "Naren";
            Console.WriteLine(s1);
            string s2 = "Naren";
            Console.WriteLine(s2);

            Console.WriteLine(s1.Equals(s2));
            Console.ReadLine();

        }
    }
}
