namespace BankSystem.Models
{
    using BankSystem.Contracts;
    using BankSystem.Models;
    using System;

    public class DepositAccount : Account, IAccount, IWithdrawable, IDepositable
    {
        public DepositAccount(ICustomer customer, decimal balance, double interestRate)
            :base(customer, balance, interestRate)
        {
        }

        public void Withdraw(decimal amount)
        {
            if (this.Balance < amount)
            {
                throw new ArgumentOutOfRangeException("Insufficient amount of money!");
            }

            this.Balance -= amount;
            Console.WriteLine(string.Format("{0} withdrew {1}lv. {0} account now have {2}lv.", 
                this.Customer.Name, amount, this.Balance));
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Amount must be positive number!");
            }

            this.Balance += amount;
            Console.WriteLine(string.Format("{0} deposited {1}lv. {0} account now have {2}lv.",
                this.Customer.Name, amount, this.Balance));
        }

        public override decimal CalculateInterest(double months)
        {
            if (this.Balance >= 0 && this.Balance < 1000)
            {
                return this.Balance;
            }

            return base.CalculateInterest(months);
        }
    }
}
