namespace MultimediaShop.Models
{
    using System;
    using System.Text;
    using MultimediaShop.Enumerations;
    using MultimediaShop.Interfaces;
    using MultimediaShop.Models.Items;

    public class Rent : IRent
    {
        private IItem item;

        public Rent(IItem item, DateTime rentDate, DateTime deadline)
        {
            this.Item = item;
            this.RentDate = rentDate;
            this.Deadline = deadline;
        }

        public Rent(IItem item, DateTime rentDate)
            : this(item, rentDate, rentDate.AddDays(30))
        {
        }

        public Rent(IItem item)
            : this(item, DateTime.Now, DateTime.Now.AddDays(30))
        {
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
                    throw new ArgumentNullException("Item cannot be null!");
                }

                this.item = value;
            }
        }

        public RentState RentState
        {
            get
            {
                var now = DateTime.Now;

                if (this.ReturnDate.Year > 1)
                {
                    return RentState.Returned;
                }
                else if (now > this.Deadline)
                {
                    return RentState.Overdue;
                }
                else
                {
                    return RentState.Pending;
                }
            }
        }

        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public DateTime Deadline { get; set; }

        public decimal RentFine()
        {
            decimal rentFine = 0;
            DateTime returnDate = this.Deadline;
            DateTime todayDate = DateTime.Now;
            TimeSpan daysDifference = todayDate - returnDate;
            for (int startDate = 0; startDate < daysDifference.Days; startDate++)
            {
                rentFine += 0.01m * this.item.Price;
                returnDate = returnDate.AddDays(1);
            }
            
            return Math.Round(rentFine, 2);
        }

        public void ReturnItem()
        {
            this.ReturnDate = DateTime.Now;
        }

        public override string ToString()
        {
            StringBuilder salesOutput = new StringBuilder();

            salesOutput.AppendLine("- Rent " + this.RentState);
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

            salesOutput.AppendLine("Rent fine: " + this.RentFine());

            return salesOutput.ToString();
        }
    }
}