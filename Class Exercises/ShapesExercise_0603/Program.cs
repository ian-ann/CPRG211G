using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
/*    abstract class Shape
    {
        public abstract double area();
            }*/

    public interface IShape
        { 
            void area();
        }


    class Rectangle : IShape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public void area()
        {
            Console.WriteLine("Rectangle Area: {0}", length * width);
        }
    }
    class Circle : IShape //Shape 
    {

        private double radius; 
        public Circle(double r)
        {
            radius = r;
        }

        public void area() //public override double area()
        {
            Console.WriteLine("Circle Area: {0}", 3.14 * radius*radius);
            //return (3.14*radius*radius);
        }
    }

    class Square: IShape //Shape
    {
        private double side;
        public Square(double s)
        {
            side = s;
        }

        public void area() // public override double area()
        {
            Console.WriteLine("Square Area: {0}", side * side);
            //return (side*side);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(2,4);
            r.area();
            Circle c = new Circle(5.0);
            c.area();
            // Console.WriteLine("Area of Circle = {0}", c.area());
            Square s = new Square(2.5);
            s.area();
            // Console.WriteLine("Area of Square = {0}",s.area());
        }
    }
}
