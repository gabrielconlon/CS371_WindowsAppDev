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
            int[] grades = new int[] {101, 98, 80, 80, 60, 05}; // notice the grades are different than what is output, proof of serialization

            Schedule Classes = new Schedule(new string[] { "CS273", "CS371","JA102" }, grades );
            //for (int i = 0; i < Classes.Length; ++i)
            //{
            //    string name = "Class " + (i+1);
            //    Classes[i] = randomGradeBook(name, rand);
            //}

            Console.WriteLine("Class\tGrades:");
            for (int i = 0; i < 3; ++i)
            {
                string longgrades = "";
                foreach(var j in Classes[i].Grades)
                    longgrades += j + " ";
                Console.WriteLine(Classes[i].CourseName + "\t" + longgrades);
            }

            #region LINQ to find average score
            //var averages = from value in Classes
            //               where value.Average > 70
            //               orderby value.Max descending
            //               select new {classname = value.CourseName, max = value.Max};
            //foreach (var v in averages)
            //    Console.WriteLine(v);
            #endregion



        }
    }
}
