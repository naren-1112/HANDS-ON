//Program.cs
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static P1.Program;


namespace P1
{
    internal class Program
    {
        public delegate string stren5(string spo, string spo1);
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the string");
            string m = Console.ReadLine();
            strin s1 = new strin();
            str1 s2 = new str1(s1.lengthofstring);
            s2(m);
           Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter username");//2
            string g = Console.ReadLine();
            str1 s3 = new str1(s1.greet);
            s3(g);
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Enter the two numbers");//3
            int yu = Convert.ToInt32(Console.ReadLine());
            int uy = Convert.ToInt32(Console.ReadLine());
            integer mi = new integer();
            str2[] d3 = new str2[3] { mi.Add, mi.Sub, mi.Multiply };
            str2 d4 = (str2)MulticastDelegate.Combine(d3);
            d4(yu, uy);
            Console.ForegroundColor = ConsoleColor.Magenta; 
            Console.WriteLine("Enter productId and product name");
            Products mo = new Products();
            mo.PId = Convert.ToInt32(Console.ReadLine());
            mo.Name = Console.ReadLine();
            str3 poi = new str3(mo.Display);
            poi(mo);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter the year,Month,date");
            int year = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int date = Convert.ToInt32(Console.ReadLine());
            Employee emp = new Employee();
            DateTime t = new DateTime(year, month, date);
            emp.Joining = t;
            str4 se = new str4(emp.Expyrs);
            int poiu = se(emp.Joining);
            Console.WriteLine($"Years of exp {poiu}");
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("Enter strings to Concatenate");
            string yum = Console.ReadLine();
            string muy = Console.ReadLine();
            stren5 dpo = delegate (string so, string su)
            {
                return so + su;
            };
            string sod = dpo(yum, muy);
            Console.WriteLine($"Concatenated string is {sod}");
            Console.ReadLine();
        }
    }
}

//Class.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public delegate void str1(string s);
    public delegate void str2(int i, int j);
    public delegate void str3(Products p);
    public delegate int str4(DateTime t);
    public class strin
    {
        public void lengthofstring(string s)
        {
            Console.WriteLine(s.Length);

        }
        public void greet(string s)
        {
            Console.WriteLine($"Hello {s}");
        }
    }
    public class integer
    {
        public void Add(int i, int j)
        {
            Console.WriteLine($"Addition is {i + j}");
        }
        public void Sub(int i, int j)
        {
            if (i > j)
            {
                Console.WriteLine($"Subtraction is {i - j}");
            }
            else
            {
                Console.WriteLine($"Subtraction is {j - i}");
            }
        }
        public void Multiply(int i, int j)
        {
            Console.WriteLine($"Multiplication is {j * i}");
        }

    }
    public class Products
    {
        public int PId
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public void Display(Products p)
        {
            Console.WriteLine($"Product id is {p.PId} and name is {p.Name}");
        }
    }
    public class Employee
    {
        private DateTime _joining;
        public DateTime Joining
        {
            get { return _joining; }
            set { _joining = value; }

        }
        public int Expyrs(DateTime ji)
        {
            int p = DateTime.Now.Year - ji.Year;
            return p;
        }
    }
}
