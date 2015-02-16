namespace Interest_Calculator
{
    using System;

    public class InterestCalculatorMain
    {
        public static void Main()
        {
            var compoundInterest = new InterestCalculator(500m, 5.6, 10, GetCompoundInterest);
            Console.WriteLine("Compound interest: " + compoundInterest.ResultInterest);

            var simpleInterest = new InterestCalculator(2500m, 7.2, 15, GetSimpleInterest);
            Console.WriteLine("Simple interest: " + simpleInterest.ResultInterest);
        }

        private static decimal GetSimpleInterest(decimal sum, double interest, int years)
        {
            decimal simpleInterest = sum * (1 + (decimal)((interest / 100) * years));

            return simpleInterest;
        }

        private static decimal GetCompoundInterest(decimal sum, double interest, int years)
        {
            byte n = 12;
            decimal compoundInterest = sum * (decimal)Math.Pow((double)(1 + (interest / n / 100)), years * n);

            return compoundInterest;
        }
    }
}
