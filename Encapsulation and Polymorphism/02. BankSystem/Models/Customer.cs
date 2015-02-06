namespace BankSystem.Models
{
    using System;
    using BankSystem.Contracts;

    public abstract class Customer : ICustomer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Customer name cannot be null!");
                }

                this.name = value;
            }
        }
    }
}
