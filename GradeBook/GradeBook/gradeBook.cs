using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook
{
    class gradeBook
    {
        public gradeBook(string courseName)
        {
            CourseName = courseName;
        }
        public gradeBook(string courseName, int[] grades)
        {
            CourseName = courseName;
            Grades = grades;
        }

        public int[] Grades
        {
            set;
            get;
        }

        private string courseName;
        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }

        public int Max
        {
            get
            {
                return Grades.Max();
            }
        }
        public double Average
        {
            get
            {
                return Grades.Average();
            }
        }

        public void displayMessage()
        {
            Console.WriteLine("Grade book for course \"{0}\"", CourseName);
            for (int i = 0; i < Grades.Length; ++i)
                Console.WriteLine("Student{0}\t{1}", i + 1, Grades[i]);
        }

        public override string ToString()
        {
            return string.Format("{0, -10} {1}", courseName, Average);
        }
    }
}
