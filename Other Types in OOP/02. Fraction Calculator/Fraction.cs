namespace Fraction_Calculator
{
    using System;

    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }

            set
            {
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }

            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("Cannot devide by zero!");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            f1.Numerator *= f2.Denominator;
            f2.Numerator *= f1.Denominator;
            long newNumerator = f1.Numerator + f2.Numerator;
            long commonDenominator = f1.Denominator * f2.Denominator;
            Fraction newFraction = new Fraction(newNumerator, commonDenominator);

            return newFraction;
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            f1.Numerator *= f2.Denominator;
            f2.Numerator *= f1.Denominator;
            long newNumerator = f1.Numerator - f2.Numerator;
            long commonDenominator = f1.Denominator * f2.Denominator;
            Fraction newFraction = new Fraction(newNumerator, commonDenominator);

            return newFraction;
        }

        public override string ToString()
        {
            return string.Format("{0}", (decimal)this.Numerator / (decimal)this.Denominator);
        }
    }
}
