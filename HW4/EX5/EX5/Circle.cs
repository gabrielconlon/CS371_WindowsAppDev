using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX5
{
    public class Circle : IGeometric2d
    {
        public double[] Sides { get; set; }
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                area = Math.PI * Math.Pow(radius, 2);
                perimeter = Math.PI * radius * 2;
            }
        }

        private double perimeter;
        public double Perimeter { get { return perimeter; } }

        private double area;
        public double Area { get { return area; } }

        public Circle(double r)
        {
            radius = r;
            Sides = new double[1];
            area = Math.PI * Math.Pow(radius, 2);
            perimeter = Math.PI * radius * 2;
        }
    }
}
