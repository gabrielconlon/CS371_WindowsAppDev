using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            //test me!
            List<IGeometric2d> shapes = new List<IGeometric2d>() {new Rectangle(2, 5), new Square(4), new Triangle(3, 4, 4), new Circle(10)};

            foreach (var i in shapes)
                Console.WriteLine(i + "\n");


            Console.WriteLine("Set new Dimensions");
            Console.WriteLine("Shape 1: Rectangle");
            ((Rectangle)shapes[0]).setSide();
            Console.WriteLine("Shape 2: Square");
            ((Square)shapes[1]).setSide();
            Console.WriteLine("Shape 3: Triangle");
            ((Triangle)shapes[2]).setSide();
            Console.WriteLine("Shape 4: Circle");
            ((Circle)shapes[3]).setRadius();


            foreach (var i in shapes)
                Console.WriteLine(i + "\n");

        }
    }
}
