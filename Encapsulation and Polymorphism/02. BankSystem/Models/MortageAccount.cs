namespace BankSystem.Models
{
    using System;
    using BankSystem.Contracts;

    public class MortageAccount : Account, IDepositable
    {
        public MortageAccount(ICustomer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Amount must be positive number!");
            }

            this.Balance += amount;
            Console.WriteLine(string.Format("{0} deposited {1}lv. {0} account now have {2}lv.", this.Customer.Name, amount, this.Balance));
        }

        public override decimal CalculateInterest(double months)
        {
            int interestRatePeriod;
            decimal interestRate;
            if (this.Customer is CompanyCustomer)
            {
                interestRatePeriod = 12;

                if (months - interestRatePeriod <= 0)
                {
                    return base.CalculateInterest(months) / 2;
                }
                else
                {
                    interestRate = (base.CalculateInterest(interestRatePeriod) / 2) +
                        base.CalculateInterest(months - interestRatePeriod);
                    return interestRate;
                }
            }
            else
            {
                interestRatePeriod = 6;

                if (months <= 6)
                {
                    return this.Balance;
                }
                else
                {
                    return base.CalculateInterest(months - interestRatePeriod);
                }
            }
        }
    }
}
