using Microsoft.VisualBasic.FileIO;
using P1c;
using System.Transactions;

namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> m = new List<Employee>();
            earn:
            Console.WriteLine(" 1.Add\n 2.Delete\n 3.Edit");
            int y = Convert.ToInt32(Console.ReadLine());

            Dept CS = new Dept();
            



            switch (y)
            {
                case 1:
                
                    Console.WriteLine("Enter deptno");
                    CS.DeptNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("DeptName");
                    CS.DeptName = Console.ReadLine();
                    Console.WriteLine("Location of department");
                    CS.Location = Console.ReadLine();
                    start:
                    numb s1 = new numb(CS.Adding);
                    CS=s1(CS);
                    foreach(Employee e in CS.prod)
                    {
                        if (!m.Contains(e))
                            m.Add(e);

                    }
                    Console.WriteLine("Enter Yes to add further");
                    string mk=Console.ReadLine();
                    if (mk == "Yes")
                    {
                        goto start;
                    }
                    break;
                case 2:
                    Employee mp = new Employee();
                    Console.WriteLine("Enter employee id to delete");
                    int mkt=Convert.ToInt32(Console.ReadLine());
                    m =mp.Delete(mkt,m);
                    mp.Display(m);
                    break;
                case 3:
                    Console.WriteLine("Enter employee id to edit");
                    int ktm=Convert.ToInt32(Console.ReadLine());
                    Employee mpt = new Employee();
                    m= mpt.Edit(ktm,m);
                    mpt.Display(m);

                    break;
            }

            Employee mt = new Employee();
            Console.WriteLine("Display all Employee names");
            numb1 ns = new numb1(mt.Display);
            ns(m);
            numb1 ns1 = new numb1(mt.Displaybymgr);
            ns1(m);
            Console.WriteLine("Enter Yes to restart");
            string pass=Console.ReadLine();
            if (pass == "Yes")
            {
                goto earn;
            }
            Console.ReadLine();
        }
    }
}

//Class.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace P1c
{
    public delegate Dept numb(Dept p); 
    public delegate void numb1(List<Employee> m);
    public delegate List<Employee> numb2(int i, List<Employee> p);
    public class Dept
    {
        public int DeptNo
        {
            get;
            set;
        }
        public string DeptName
        {
            get;
            set;
        }
        public string Location
        {
            get;
            set;
        }
        public List<Employee> prod
        {
            get;
            set;
        }
        
        List<Employee> p = new List<Employee>();
        public Dept Adding(Dept t)
        {
           
           
            if(p.Count <= 10)
            {
                Employee m = new Employee();
                Console.WriteLine("enter the employee no");
                m.EmployeeNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name");
                m.Empname = Console.ReadLine();
                Console.WriteLine("Enter the dept no");
                m.Deptno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the salary");
                m.Salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the manager");
                m.Manager = Console.ReadLine();



                p.Add(m);
                t.prod = p;
                return t;
            }
            else
            {

                Console.WriteLine("You can't add more than 10 in a dept");
                return t;
              
            }
        }
       
       
    }
    public class Employee
    {
       
        public int EmployeeNo
        {
            get;
            set;
        }
        public string Empname
        {
            get;
            set;
        }
        public int Deptno
        {
            get;
            set;
        }
        public int Salary
        {
            get;
            set;

        }
        public string Manager
        {
            get;
            set;
        }
        public List<Employee> Edit(int EmpId, List<Employee> m)
        {
            Console.WriteLine("Which part you want to modify?\n 1.Empname\n  2.Salary\n 3.Manager");
            int w = Convert.ToInt32(Console.ReadLine());
            switch (w)
            {
                case 1:
                    foreach (var item in m)
                    {
                        if (item.EmployeeNo == EmpId)
                        {

                            Console.WriteLine("Enter the new name which is to modify");
                            item.Empname = Console.ReadLine();

                        }
                    }
                    
                    break;

                case 2:
                    foreach (var item in m)
                    {
                        if (item.EmployeeNo == EmpId)
                        {

                            Console.WriteLine("Enter the salary which is to modify");
                            item.Salary = Convert.ToInt32(Console.ReadLine());

                        }
                    }
                  
                    break;
                case 3:
                    foreach (var item in m)
                    {
                        if (item.EmployeeNo == EmpId)
                        {

                            Console.WriteLine("Enter the new manager which is to modify");
                            item.Manager = Console.ReadLine();


                        }
                    }
                  
                    break;
                default:
                    break;
            }

            return m;
        }
        public List<Employee> Delete(int id, List<Employee> m)
        {
            m = m.Where(m1 => m1.EmployeeNo != id).ToList();
            return m;

        }
        public void Displaybymgr(List<Employee> m)
        {
            Console.WriteLine("Enter the name of the manager whom name of employees you want to see ");
            string s = Console.ReadLine();
            var ti=m.Where(mi=> mi.Manager == s).ToList();
            if(ti.Count > 0)
            {
                foreach (var item in ti)
                    Console.WriteLine(item.Empname);
            }
            else
            {
                Console.WriteLine("No employees is working under him");
            }
        }
        public void Display(List<Employee> m)
        {
            foreach(var item in m)
            {
                Console.WriteLine($"{item.EmployeeNo} {item.Empname} {item.Deptno} {item.Salary} {item.Manager}\n");
            }

        }
       
    }
}
