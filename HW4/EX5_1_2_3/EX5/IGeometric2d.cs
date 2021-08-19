using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX5
{
    interface IGeometric2d
    {
        double[] Sides { get; set; }
        double Area { get; }
        double Perimeter { get; }
    }
}
