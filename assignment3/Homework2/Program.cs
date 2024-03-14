namespace Homework2
{
    internal class Program
    {
        private static Random random = new Random();
        //创建接口Shape
        public interface Shape
        {
            double getArea();
            bool isValid();

        }
        //在接口之上，具体创造出各个不同的类
        public class Rectangle : Shape
        {
            private double length;
            private double width;

            //添加一个随机数的构造函数，便于生成随机边长的形状
            public Rectangle()
            {
                //Random random = new Random();
                this.length = random.NextDouble()*20;
                this.width = random.NextDouble()*20;
            }
            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }

            public virtual double getArea()
            {
                if (!this.isValid())
                {
                    throw new ArgumentOutOfRangeException("all sides of rectangle must be greater than 0");
                }
                return length * width;
            }
            public virtual bool isValid()
            {
                if (length > 0 && width > 0)
                    return true;
                return false;
            }
        }
        public class Square : Rectangle, Shape
        {
            private double side;

            public Square()
            {
                //Random random = new Random();
                this.side = random.NextDouble() * 20;
            }

            public Square(double side) : base(side, side) => this.side = side;
            public override double getArea()
            {
                if (!this.isValid())
                {
                    throw new ArgumentOutOfRangeException("side", "side must be greater than 0");
                }
                return side * side;
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

            public Triangle()
            {
                //Random random = new Random();
                this.a = random.NextDouble() * 20;
                this.b = random.NextDouble() * 20;
                this.c = random.NextDouble() * 20;
            }
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
                    throw new ArgumentOutOfRangeException("all sides of triangle must be greater than 0");
                }
                double s = a + b + c;
                s = s / 2;
                double Area = s * (s - a) * (s - b) * (s - c);
                Area = Math.Sqrt(Area);
                return Area;
            }
            public bool isValid()
            {
                // 检查每边是否大于0，且任意两边之和大于第三边
                return this.a > 0 && this.b > 0 && this.c > 0
                       && a + b > c && a + c > b && b + c > a;
            }

        }

        //创造工厂类
        public class Factory
        {
            public static Shape creatShape()
            {
                //Random r = new Random();
                int shapeType = random.Next(3);

                switch (shapeType)
                {
                    case 0:
                        return new Rectangle();
                    case 1:
                        return new Square();
                    case 2:
                        return new Triangle();
                    default:
                        throw new InvalidOperationException("Unexpected shape type");
                }
            }

        }
        static void Main(string[] args)
        {
            //创建十个对象，并积累面积的值
            double sumArea = 0;
            for (int i = 0;i<10;i++)
            {
                Shape newShape = Factory.creatShape();
                try
                {
                    sumArea += newShape.getArea();
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("An invalid shape was generated and will be skipped.");
                }
            }
            Console.WriteLine($"The 10 randow shape's total area is {sumArea} ");
        }
    }
}
