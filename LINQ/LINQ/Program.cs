using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Program
    {
        static void DisplayResult(IEnumerable<int> result)
        {
            foreach (var ele in result.Distinct())
                Console.WriteLine(ele);
            Console.WriteLine("The average is {0}", result.Average());
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; ++i)
                array[i] = rand.Next(11);

            var valuesGreaterThan5 = from value in array
                                  where value > 5
                                  orderby value
                                  select value;

            Console.WriteLine("Values greater than 5: {0}", valuesGreaterThan5.Count());
            DisplayResult(valuesGreaterThan5);

            var valuesLessEqual5 = from value in array
                                   where value <= 5
                                   orderby value descending
                                   select value;

            Console.WriteLine("Values less than 5: {0}", valuesLessEqual5.Count());
            DisplayResult(valuesLessEqual5);

            var valuesingroups = from value in array
                                 group value by (value % 2 != 0 ? "odd" : "even");

            foreach (var bucket in valuesingroups)
            {
                Console.WriteLine("Bucket: {0}", bucket.Key);
                foreach (var element in bucket)
                    Console.WriteLine(element);
            }
        }
    }
}
