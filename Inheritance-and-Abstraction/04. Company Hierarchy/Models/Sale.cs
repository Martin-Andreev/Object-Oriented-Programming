namespace Company_Hierarchy.Models
{
    using System;
    using Company_Hierarchy.Contracts;

    class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name cannot be null or empty!");
                }
                this.productName = value;
            }
        }

        public DateTime Date { get; set; }

        private decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative number!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Product: {0}. Price: {1}lv. Date sale: {2}", this.ProductName, this.Price, this.Date);
        }
    }
}
