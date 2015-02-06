namespace BankSystem.Models
{
    using System;
    using BankSystem.Contracts;

    class CompanyCustomer : Customer, ICustomer
    {
        public CompanyCustomer(string name)
            :base(name)
        {
        }
    }
}
