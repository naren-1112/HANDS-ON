using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class P3
    {
        static void Main(string[] args)
        {
            employee e = new employee(1, "Naren", 20000, 1);
            Console.WriteLine("Employee id :" + " " + e.empno);
            Console.WriteLine("Employee name:" + " " + e.ename);
            Console.WriteLine("Employee salary:" + " " + e.sal);
            Console.WriteLine("Employee dept no:" + " " + e.deptno);
            Console.ReadLine();
        }
    }
    struct employee
    {
        public int empno;
        public string ename;
        public int sal;
        public int deptno;

        public employee(int emp_id, string emp_name, int sal, int depno)
        {
            this.empno = emp_id;
            this.ename = emp_name;
            this.sal = sal;
            this.deptno = depno;
            
        }
    }
    }

