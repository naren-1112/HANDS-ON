//Program.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Mphasis\C#\12-Sep\P1\MyLibrary\bin\Debug\MyLibrary.dll";

            Assembly asm = Assembly.LoadFrom(path);
            //  Assembly asm1=Assembly.GetAssembly(typeof(path));
            Type[] types = asm.GetTypes();
            foreach (var item in types)
            {
                Console.WriteLine("name= " + item.Name);//classname
                Console.WriteLine("Full Name= " + item.FullName);//(assemblyname/namespacename) . class

                Console.WriteLine("IS Class=" + item.IsClass);
                Console.WriteLine("IS Absatract=" + item.IsAbstract);
                Console.WriteLine("Whether public " + item.IsPublic);


                Console.WriteLine("==============================================================");
                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                    // for displaying each method
                    Console.WriteLine("--> Method : {0}", method.Name);



                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        Console.WriteLine(" Parameter : {0} Type : {1}",
                        arg.Name, arg.ParameterType);


                    }
                }
                Console.WriteLine("========================================================");
                Type t = null;
                t = asm.GetType(item.FullName);

                object obj = Activator.CreateInstance(t);

                int ans = (int)item.InvokeMember("Cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[2] { 10, 11 });


                //double ans1 = (double)
                item.InvokeMember("SquareRoot", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[2] { 36.00, 225.00});
                Console.ReadLine();
                break;
                
            }
        }
    }
}

//Class.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Class1
        {
            public double i { get; set; }
            public double j { get; set; }
            public double num1
            {
                get { return i; }
                set { i = value; }
            }
            public double num2
            {
                get { return j; }
                set { j = value; }
            }

            public int Cube(int i, int j)
            {
                int p = i * i * i;
                int q = j * j * j;
                Console.WriteLine("Cube of 1st number: " + p + "\n" + "Cube of 2nd number: " + q);
                return 0;
            }
            public void SquareRoot(double i, double j)
            {

                double k = Math.Sqrt(i);
                double v = Math.Sqrt(j);
                Console.WriteLine("Square Root of 1st Number {0} = {1}: ", i, k);
                Console.WriteLine("Square Root of 2nd Number {0} = {1}: ", j, v);

            }


        }
    }

