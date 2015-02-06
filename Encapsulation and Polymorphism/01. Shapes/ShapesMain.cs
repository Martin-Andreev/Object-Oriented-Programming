namespace Shapes
{
    using System;

    class Program
    {
        static void Main()
        {
            Circle circle1 = new Circle(4.5);
            Circle circle2 = new Circle(12.25);

            Rectangle rectangle1 = new Rectangle(5.55, 7);
            Rectangle rectangle2 = new Rectangle(13, 2.24);

            Triangle triangle1 = new Triangle(5.9, 3.8, 17.7);
            Triangle triangle2 = new Triangle(2, 4, 6);

            IShape[] shapes = new IShape[6] { circle1, circle2, rectangle1, rectangle2, triangle1, triangle2 };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape: {0} --> Area: {1} - Perimeter: {2}", 
                    shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}
