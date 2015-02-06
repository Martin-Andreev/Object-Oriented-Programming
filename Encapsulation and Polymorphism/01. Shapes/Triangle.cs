namespace Shapes
{
    using System;

    class Triangle : BasicShape
    {
        private double thirdSide;

        public Triangle(double width, double height, double thirdSide)
            : base(width, height)
        {
            this.ThirdSide = thirdSide;
        }

        public double ThirdSide
        {
            get { return this.thirdSide; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The third side of the triangle cannot be negative number!");
                }

                this.thirdSide = value;
            }
        }

        public override double CalculateArea()
        {
            double triangleArea = (this.Width + this.Height) / 2;

            return Math.Round(triangleArea, 2);
        }

        public override double CalculatePerimeter()
        {
            double trianglePerimeter = this.Width + this.Height + this.ThirdSide;

            return Math.Round(trianglePerimeter, 2);
        }
    }
}
