using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
   public class P4
    {
        public static void split()
        {
            string text = "N a,r.e/n";
            Console.WriteLine("Splitting " + text);

            string[] result = text.Split(' ', ',', '.', '/');

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();

        }
    }  }
