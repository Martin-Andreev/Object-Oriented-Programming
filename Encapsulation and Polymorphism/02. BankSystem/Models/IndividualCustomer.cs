namespace BankSystem.Models
{
    using System;
    using BankSystem.Contracts;

    public class IndividualCustomer : Customer, ICustomer
    {
        public IndividualCustomer(string name)
            : base(name)
        {
        }
    }
}
