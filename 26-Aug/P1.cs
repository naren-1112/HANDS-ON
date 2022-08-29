using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1

{
    class P1
    {
        static void Main(string[] args)
        {
            Student[] student = { new Student(), new Student(), new Student() };

            student[0].SetStudent(4567, "Naren", 49);
            student[1].SetStudent(4562, "Sarath", 44);
            student[2].SetStudent(4581, "Praveen", 30);

            student[0].DisplayStudent();
            student[1].DisplayStudent();
            student[2].DisplayStudent();
        }
    }
    public struct Student
    {
        public int Id;
        public string Name;
        public int Marks;


        public void SetStudent(int id, string name, int marks)
        {
            Id = id;
            Name = name;
            Marks = marks;
        }

        public void DisplayStudent()
        {
            Console.WriteLine("Student:");
            Console.WriteLine("\tId: " + Id);
            Console.WriteLine("\tName: " + Name);
            Console.WriteLine("\tMarks: " + Marks);
            Console.WriteLine("\n");
            Console.ReadLine();
        }

    }
}
