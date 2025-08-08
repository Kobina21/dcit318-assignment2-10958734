using System;

namespace AbstractClassesDemo
{
    // Abstract class Shape with abstract method GetArea()
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class Circle that implements GetArea()
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
    }

    // Derived class Rectangle that implements GetArea()
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return length * width;
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Classes and Methods Demo ===\n");

            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            // Display areas
            Console.WriteLine($"Circle with radius {circle.Radius}:");
            Console.WriteLine($"Area = {circle.GetArea():F2} square units\n");

            Console.WriteLine($"Rectangle with length {rectangle.Length} and width {rectangle.Width}:");
            Console.WriteLine($"Area = {rectangle.GetArea():F2} square units\n");

            // Demonstrate polymorphism with a collection of shapes
            Console.WriteLine("=== Polymorphism Demo ===");
            Shape[] shapes = new Shape[]
            {
                new Circle(3.0),
                new Rectangle(2.0, 8.0),
                new Circle(7.0),
                new Rectangle(5.0, 5.0)
            };

            for (int i = 0; i < shapes.Length; i++)
            {
                string shapeType = shapes[i] is Circle ? "Circle" : "Rectangle";
                Console.WriteLine($"Shape {i + 1} ({shapeType}): Area = {shapes[i].GetArea():F2} square units");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
