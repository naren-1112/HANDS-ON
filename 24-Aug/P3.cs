using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
   public class P3
    {
        public static void index()
        {
            string s1 = "Welcome";
            Console.WriteLine(s1);
            Console.WriteLine("Index of c");
            int index = s1.IndexOf('c');
            Console.WriteLine(index);
            Console.ReadLine();       
        }
    }
}
