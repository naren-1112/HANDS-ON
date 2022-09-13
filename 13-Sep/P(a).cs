//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Type t = null;
                t = asm.GetType(item.FullName);

                object obj = Activator.CreateInstance(t);

                int ans = (int)item.InvokeMember("Cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[2] {7 , 11 });


                //double ans1 = (double)
                item.InvokeMember("SquareRoot", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[2] { 49.00, 121.00 });

                break;

            }


//Class.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalciLib
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
