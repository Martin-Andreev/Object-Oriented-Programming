namespace BankSystem.Models
{
    using System;
    using BankSystem.Contracts;

    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(ICustomer customer, decimal balance, double interestRate)
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
            int freeInterestRate;
            if (this.Customer is IndividualCustomer)
            {
                freeInterestRate = 3;

                if (months <= freeInterestRate)
                {
                    return this.Balance;
                }
                else
                {
                    return base.CalculateInterest(months - freeInterestRate);
                }
            }
            else
            {
                freeInterestRate = 2;
            }

            if (months <= freeInterestRate)
            {
                return this.Balance;
            }
            else
            {
                return base.CalculateInterest(months - freeInterestRate);
            }
        }
    }
}
