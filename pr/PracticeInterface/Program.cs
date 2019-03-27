using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "Petr", FullName = "Poroshenko", Grades = new int[]{ 1, 2, 3, 4 }
            };

            Console.WriteLine($"{student.GetFullName()}, {student.GetName()} - сред оценка {student.GetAvgGrade()}");
        }
    }
}
