namespace Interest_Calculator
{
    using System;

    public class InterestCalculator
    {
        private decimal moneySum;
        private double interest;
        private int years;
        private decimal resultInterest;

        public InterestCalculator(decimal moneySum, double interest, int years, CalculateInterest del)
        {
            this.MoneySum = moneySum;
            this.Interest = interest;
            this.Years = years;
            this.ResultInterest = del(this.MoneySum, this.Interest, this.Years);
        }

        public delegate decimal CalculateInterest(decimal sum, double interest, int years);

        public decimal MoneySum
        {
            get { return this.moneySum; }
            set { this.moneySum = value; }
        }

        public double Interest
        {
            get
            {
                return this.interest;
            }

            set
            {
                if (value < 0)
                {
                    throw new FormatException("Interest can not be negative number!");
                }

                this.interest = value;
            }
        }

        public int Years
        {
            get
            {
                return this.years;
            }

            set
            {
                if (value < 0)
                {
                    throw new FormatException("Period can not be negative nubmer!");
                }

                this.years = value;
            }
        }

        public decimal ResultInterest
        {
            get
            {
                return Math.Round(this.resultInterest, 4);
            }

            set
            {
                this.resultInterest = value;
            }
        }
    }
}
