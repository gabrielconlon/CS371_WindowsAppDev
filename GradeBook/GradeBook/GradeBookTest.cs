using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook
{
    class GradeBookTest
    {
        static gradeBook randomGradeBook(string name, Random rand)
        {
            
            int[] grades = new int[10];
            for (int i = 0; i < grades.Length; ++i)
            {
                grades[i] = rand.Next(40,101);
            }

            gradeBook temp = new gradeBook(name, grades);

            return temp;

        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            gradeBook[] Classes = new gradeBook[5];

            for (int i = 0; i < Classes.Length; ++i)
            {
                string name = "Class " + (i+1);
                Classes[i] = randomGradeBook(name, rand);
            }

            Console.WriteLine("Class\tAverage:");
            foreach (var c in Classes)
                Console.WriteLine(c);

            var averages = from value in Classes
                           where value.Average > 70
                           orderby value.Max descending
                           select new {classname = value.CourseName, max = value.Max};
            foreach (var v in averages)
                Console.WriteLine(v);
                           
            
            
        }
    }
}
