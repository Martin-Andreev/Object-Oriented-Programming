namespace BankSystem.Contracts
{
    using System;

    public interface IWithdrawable
    {
        void Withdraw(decimal amount);
    }
}
