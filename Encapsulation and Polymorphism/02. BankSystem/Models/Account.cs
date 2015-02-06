namespace BankSystem.Models
{
    using System;
    using BankSystem.Contracts;

    public abstract class Account : IAccount, IDepositable
    {
        private ICustomer customer;
        private decimal balance;
        private double interestRate;

        protected Account(ICustomer customer, decimal balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public ICustomer Customer
        {
            get
            {
                return this.customer;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer cannot be null!");
                }

                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            protected set
            {
                this.balance = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }

            protected set
            {
                this.interestRate = value;
            }
        }

        public virtual void Deposit(decimal amount)
        {
        }

        public virtual decimal CalculateInterest(double months)
        {
            decimal interest = this.Balance * (decimal)(1 + ((this.InterestRate * months) / 100));
            this.Balance = interest;
            return Math.Round(interest, 2);
        }
    }
}
