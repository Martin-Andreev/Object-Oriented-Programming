namespace BankSystem.Models
{
    using System;
    using BankSystem.Contracts;

    public class CompanyCustomer : Customer, ICustomer
    {
        public CompanyCustomer(string name)
            : base(name)
        {
        }
    }
}
