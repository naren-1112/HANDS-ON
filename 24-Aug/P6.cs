using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ReusableCodeLibrary
{
    public class P6
    {
        public static void file()
        {
            string s = "D:\\firstFile.txt";
            File.Create(s);
            Console.ReadLine();


        }
    }
}
