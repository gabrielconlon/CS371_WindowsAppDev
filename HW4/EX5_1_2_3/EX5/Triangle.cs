using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX5
{
    public class Triangle : Polygon
    {
        private double area;
        private double Base
        {
            get { return Sides[0]; }
            set { Sides[0] = value; }
        }
        private double hypotenus
        {
            get { return Sides[1]; }
            set { Sides[1] = value; }
        }
        private double height
        {
            get { return Sides[2]; }
            set { Sides[2] = value; }
        }

        public Triangle(double s1, double s2, double s3)
        {
            Sides = new double[3];

            Base = s1;
            hypotenus = s2;
            height = s3;
        }

        public override void setSide()
        {
            perimeter = 0;
            area = 1;
            Console.WriteLine("Enter the length of the base: ");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the hypotenus: ");
            hypotenus = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the height: ");
            height = Convert.ToDouble(Console.ReadLine());

        }

        public override double Area
        {
            get
            {
               area = Base * height * 0.5;
               return area;
            }
        }

        public override string ToString()
        {
            return string.Format("Triangle " + base.ToString());
        }
    }
}
