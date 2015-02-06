namespace BankSystem.Contracts
{
    using System;

    public interface IDepositable
    {
        void Deposit(decimal amount);
    }
}