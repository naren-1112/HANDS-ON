using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class P5
    {
        static void Main(string[] args)
        {
            Employees[] emp = { new Employees(),
                       new Employees(),
                       new Employees(), new Employees()};


            emp[0].SetEmployee(1, "Naren", 20000, 1);
            emp[1].SetEmployee(2, "SK", 25000, 2);
            emp[2].SetEmployee(3, "Sarath", 30000, 3);
            emp[3].SetEmployee(3, "Yashwant", 35000, 3);
            
            emp[0].DisplayEmployee();
            emp[1].DisplayEmployee();
            emp[2].DisplayEmployee();
            emp[3].DisplayEmployee();

        }
    }
    public struct Employees
    {

 
        public int Id;
        public string Name;
        public int sal;
        public int depno;

        public void SetEmployee(int id, string name, int salr, int depnos)
        {
            Id = id;
            Name = name;
            sal = salr;
            depno = depnos;
        }

       
        public void DisplayEmployee()
        {
            Console.WriteLine("Employee:");
            Console.WriteLine("\tId    : " + Id);
            Console.WriteLine("\tName   : " + Name);
            Console.WriteLine("\tsal   : " + sal);
            Console.WriteLine("\tdepno  : " + depno);
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
