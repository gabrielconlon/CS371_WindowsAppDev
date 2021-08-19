using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.0;
            foreach (var i in args)
                sum += Convert.ToDouble(i);

            Console.WriteLine("Sum is {0}", sum);
        }
    }
}
