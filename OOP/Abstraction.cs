using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Shape
    {
        public double width;
        public double height;
        public abstract double Area();
    }

    class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double Area()
        {
            return 0.5 * (width * height);
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double Area()
        {
            return width * height;
        }
    }

    class Abstraction
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction Example");
            Triangle triangle = new Triangle(10, 20);
            Console.WriteLine(triangle.Area());

            Rectangle rectangle = new Rectangle(10, 20);
            Console.WriteLine(rectangle.Area());

            Console.ReadLine();
        }
    }
}
