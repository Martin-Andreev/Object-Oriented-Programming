namespace BankSystem.Contracts
{
    using System;
    using BankSystem.Models;

    public interface IAccount
    {
        ICustomer Customer { get; set; }

        decimal Balance { get; }

        double InterestRate { get; }

        decimal CalculateInterest(double months);
    }
}
