 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2{
 public class Class_stud
    {
        public int id;
        public string Name;
        public int Age;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string SName
        {
            get { return Name; }
            set { Name = value; }
        }
        public int age
        {
            get { return Age; }
            set { Age = value; }
        }
        public  void gett()
        {
            Console.WriteLine("Enter id:");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            SName = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            age = Convert.ToInt32(Console.ReadLine());

        }
        public  void puts()
        {
            Console.WriteLine("Following are the details");
            Console.WriteLine("id: "+Id);
            Console.WriteLine("name: "+SName);
            Console.WriteLine("age: "+age);
        }
    }
