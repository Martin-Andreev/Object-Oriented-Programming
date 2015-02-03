namespace Company_Hierarchy.Models
{
    using System;
    using Company_Hierarchy.Contracts;

    class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(string firstName, string lastName, uint id, decimal netPurchaseAmount)
            : base(firstName, lastName, id)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Net purchase amount cannot be negative number!");
                }
                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" Net purchase amount: {0}lv.", this.NetPurchaseAmount);
        }
    }
}
