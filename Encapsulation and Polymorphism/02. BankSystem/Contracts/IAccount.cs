namespace BankSystem.Contracts
{
    using System;

    public interface IAccount
    {
        ICustomer Customer { get; set; }

        decimal Balance { get; }

        double InterestRate { get; }

        decimal CalculateInterest(double months);
    }
}
