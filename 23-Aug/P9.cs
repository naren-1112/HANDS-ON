using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9
{
    class P9
    {
            struct Employee
        {
            int Empno;
            string Empname;
            int Salary;
            int Deptno;






            public Employee(int Empno, string _empname, int _salary, int _deptno)
            {

                this.Empno = Empno;
                Empname = _empname;
                Salary = _salary;
                Deptno = _deptno;

            }

            public void AcceptData(int empno, string empname, int salary, int deptno)
            {
                Empno = empno;
                Empname = empname;
                Salary = salary;
                Deptno = deptno;


            }

            public void DisplayData()
            {
                Console.WriteLine();
                if (Empno == 0)
                {
                    Console.WriteLine("The enter Empno is not valid");
                }
                else
                    Console.WriteLine(Empno);
                if (String.IsNullOrEmpty(Empname))
                    Console.WriteLine("Enter name is null or empty....Plz enter valid name");
                else
                    Console.WriteLine(Empname);
                Console.WriteLine(Salary);

                if (Deptno == 0)
                {
                    Console.WriteLine("The enter Deptno is not valid");
                }
                else
                    Console.WriteLine(Deptno);


            }
            static void Main(string[] args)
            {

                Employee emp1 = new Employee();

                Console.WriteLine("Enter the employee id: ");
                int empid = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the employee Name : ");
                string empname = Console.ReadLine();

                Console.WriteLine("Enter the employee Salary : ");
                int salary = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the employee department number: ");
                int deptid = Convert.ToInt32(Console.ReadLine());



                emp1.AcceptData(empid, empname, salary, deptid);
                Console.WriteLine("Employee Details:");
                emp1.DisplayData();
                Console.ReadLine();
            }


        }
     } }
