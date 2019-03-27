using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterface
{
    public class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }
        public double AvgGrade { get; set; }

        
        public String GetName()
        {
            return Name;
        }
        public String GetFullName()
        {
            return FullName;
        }
        public Double GetAvgGrade()
        {
            for (int i = 0; i < Grades.Length; i++)
            {
                AvgGrade += Grades[i];
            }
            AvgGrade /= Grades.Length;
            return AvgGrade;
        }
    }
}
