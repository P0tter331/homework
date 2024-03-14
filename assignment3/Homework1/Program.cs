using System.Runtime.InteropServices;

namespace Homework1
{
    internal class Program
    {
        public interface Shape
        {
            double getArea();
            bool isValid();

        }
        public class Rectangle : Shape
        {
            private double length;
            private double width;

            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }

            public virtual double getArea()
            {
                if (!this.isValid())
                {
                    throw new ArgumentOutOfRangeException( "all sides of rectangle must be greater than 0");
                }
                return length*width;
            }
            public virtual bool isValid()
            {
                if(length >0&&width >0)
                    return true;
                return false;
            }
        }
        public class Square:Rectangle,Shape
        {
            private double side;

            public Square(double side) : base(side, side) => this.side = side;
            public override double getArea()
            {
                if (!this.isValid())
                {
                    throw new ArgumentOutOfRangeException("side", "side must be greater than 0");
                }
                return side*side;
            }
            public override bool isValid()
            {
                if (side > 0)
                    return true;
                return false;
            }

        }
        public class Triangle : Shape
        {
            double a;
            double b;
            double c;

            public Triangle(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public double getArea()
            {
                if (!this.isValid())
                {
                    throw new ArgumentOutOfRangeException( "all sides of triangle must be greater than 0");
                }
                double s=a+b+c;
                s = s / 2;
                double Area=s*(s-a)*(s-b)*(s-c);
                Area=Math.Sqrt(Area);
                return Area;
            }
            public bool isValid()
            {
                if (this.a>0&&this.b>0&&this.c>0)
                {
                    return true;
                }
                return false;
            }
        }
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(-1, 2);
            try
            {
                double rectangleArea = rectangle.getArea();
                Console.WriteLine(rectangleArea);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Square square = new Square(3);
            double squareArea= square.getArea();
            Console.WriteLine(squareArea);

            Triangle triangle = new Triangle(3,4,5);
            double triangleArea= triangle.getArea();
            Console.WriteLine(triangleArea);

        }
    }
}
