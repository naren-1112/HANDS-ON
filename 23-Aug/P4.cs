using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class P4
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.getdata();
            obj.ShowData();
        }
    }
    public struct Employee
    {
        public int EmpNo;
        public string eName;
        public int sal;
        public int deptno;

        public Employee(int ID, string name, int salary, int dep)
        {
            EmpNo = ID;
            eName = name;
            sal = salary;
            deptno = dep;
        }
        public void getdata()
        {
            Console.WriteLine("Enter Employee id");
            EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            eName = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Deptno");
            deptno = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowData()
        {
            Console.WriteLine("Employee ID:" + EmpNo);
            Console.WriteLine("Employee Name:" + eName);
            Console.WriteLine("Employee salary:" + sal);
            Console.WriteLine("Employee dept.no:" + deptno);
            Console.ReadLine();

        }
    }
}
