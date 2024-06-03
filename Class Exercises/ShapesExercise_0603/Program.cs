using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    abstract class Shape
    {
        public abstract double area();
            }

    class Circle : Shape 
    {
        private double radius; 
        public Circle(double r)
        {
            radius = r;
        }

        public override double area()
        {
            return (3.14*radius*radius);
        }
    }

    class Square: Shape
    {
        private double side;
        public Square(double s)
        {
            side = s;
        }

        public override double area()
        {
            return (side*side);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5.0);
            Console.WriteLine("Area of Circle = {0}", c.area());
            Square s = new Square(2.5);
            Console.WriteLine("Area of Square = {0}",s.area());
        }
    }
}
