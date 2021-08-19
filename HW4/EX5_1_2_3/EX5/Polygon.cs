using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX5
{
    public abstract class Polygon : IGeometric2d
    {
        public abstract double Area { get; }
        public  double perimeter;
        public double[] Sides { get; set; }

        public Polygon() { perimeter = 0; }


        public double Perimeter
        {
            get
            {
                foreach (double s in Sides)
                    perimeter += s;
                return perimeter;
            }
        }

        public abstract void setSide();

        public override string ToString()
        {
            string sideslist = "";
            foreach (double i in Sides)
                sideslist = sideslist + i + ", ";
            return string.Format(sideslist + "\nPerimeter {0}\nArea {1}", Perimeter, Area);
        }
    }
}
