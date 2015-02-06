namespace BankSystem.Models
{
    using System;
    using BankSystem.Contracts;

    class IndividualCustomer : Customer, ICustomer
    {
        public IndividualCustomer(string name)
            :base(name)
        {
        }
    }
}
