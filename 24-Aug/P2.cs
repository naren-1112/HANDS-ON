using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class P2
    {
        public static void copy()
        {
            string s1 = "Humanity is peace ";
            string s2 = string.Copy(s1);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.ReadLine();

        }
    }
}
