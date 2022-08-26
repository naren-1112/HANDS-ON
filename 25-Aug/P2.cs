using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P2
{
    class P2
    {
        static void Main(string[] args)
        {
            string path = "D:\\Mphasis\\C#\\25-Aug\\P2";
            Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();
            fname = string.Concat(path, fname);
               File.Create(path+fname);
                 Console.WriteLine("File created successfully...");    //File Creation  */

            /* Console.WriteLine("Enter your file contents");
             string con = Console.ReadLine();

             File.WriteAllText(fname, con);
             Console.WriteLine("File created successfully with Contents...");  */ // Contents


            /*  File.Copy(fname, "D:\\Mphasis\\C#\\25-Aug\\P2//1.txt");
              Console.WriteLine("copy succesfully");  */    //Copy


            /*   File.Move(fname, "D:\\Mphasis\\C#\\25-Aug\\P2\\MovedFile.txt");
               Console.WriteLine(" Moved File Succesfully");   */  //Move

            /* File.Delete(fname); */    //delete

            //FileInfo fileInfo = new FileInfo(fname);
            //Console.WriteLine("--------------");
            //Console.WriteLine(fileInfo.FullName + "  Full Name");
            //Console.WriteLine("--------------");
            //Console.WriteLine(fileInfo.Extension + " Extension");
            //Console.WriteLine("--------------");
            //Console.WriteLine(fileInfo.DirectoryName + " DirectoryName");
            //Console.WriteLine("--------------");
            //Console.WriteLine(fileInfo.CreationTime);

            Console.ReadLine();
        }

    }
}
