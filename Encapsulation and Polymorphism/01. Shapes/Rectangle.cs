namespace Shapes
{
    using System;

    class Rectangle : BasicShape 
    {
        public Rectangle(double width, double height)
            :base(width, height)
        {
        }

        public override double CalculateArea()
        {
            double rectangleArea = this.Width * this.Height;

            return Math.Round(rectangleArea, 2); ;
        }

        public override double CalculatePerimeter()
        {
            double rectanglePerimeter = (this.Width + this.Height) * 2;

            return Math.Round(rectanglePerimeter, 2);
        }
    }
}
