namespace MultimediaShop.Models
{
    using System;
    using System.Text;
    using MultimediaShop.Interfaces;
    using MultimediaShop.Models.Items;

    public class Sale : ISale
    {
        private IItem item;

        public Sale(IItem item, DateTime saleDate)
        {
            this.Item = item;
            this.SaleDate = saleDate;
        }

        public Sale(IItem item)
        {
            this.Item = item;
            this.SaleDate = DateTime.Now;
        }

        public IItem Item
        {
            get
            {
                return this.item;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Sale item cannot be null!");
                }

                this.item = value;
            }
        }

        public DateTime SaleDate { get; set; }

        public override string ToString()
        {
            StringBuilder salesOutput = new StringBuilder();

            salesOutput.AppendLine("- Sale " + this.SaleDate);
            salesOutput.AppendLine(this.Item.GetType().Name + " " + this.Item.ID);
            salesOutput.AppendLine("Title: " + this.Item.Title);
            salesOutput.AppendLine("Price: " + this.Item.Price);
            salesOutput.AppendLine("Genre: " + string.Join(" ,", this.Item.Genres));

            string itemType = this.Item.GetType().Name.ToLower();

            switch (itemType)
            {
                case "book":
                    salesOutput.AppendLine("Author: " + (this.Item as Book).Author);
                    break;

                case "video":
                    salesOutput.AppendLine("Length: " + (this.Item as Video).Length);
                    break;

                case "game":
                    salesOutput.AppendLine("Age Restriction: " + (this.Item as Game).AgeRestriction);
                    break;
            }

            return salesOutput.ToString();
        }
    }
}
