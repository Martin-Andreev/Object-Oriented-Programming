namespace Shapes
{
    using System;

    class Circle : BasicShape
    {
        public Circle(double radius)
            :base(radius, radius)
        {
        }

        public override double CalculateArea()
        {
            double circleArea = Math.PI * Math.Pow(this.Width, 2);

            return Math.Round(circleArea, 2);
        }

        public override double CalculatePerimeter()
        {
            double circlePerimeter = 2 * Math.PI * Width;

            return Math.Round(circlePerimeter, 2);
        }
    }
}
