namespace MultimediaShop.Models
{
    using System;
    using System.Collections.Generic;
    using MultimediaShop.Interfaces;

    public abstract class Item : IItem
    {
        private string id;
        private string title;
        private decimal price;

        public Item(string id, string title, decimal price, List<string> genres)
        {
            this.ID = id;
            this.Title = title;
            this.Price = price;
            this.Genres = genres;
        }

        public Item(string id, string title, decimal price, string genre)
            : this(id, title, price, new List<string>() { genre })
        {
        }

        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value == null || value.Trim() == "")
                {
                    throw new ArgumentNullException("ID cannot be empty!");
                }

                if (value.Length < 4)
                {
                    throw new ArgumentOutOfRangeException("ID must have at least 4 symbos!");
                }

                this.id = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                if (value == null || value.Trim() == "")
                {
                    throw new ArgumentNullException("Title cannot be empty!");
                }

                this.title = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative!");
                }

                this.price = value;
            }
        }

        public List<string> Genres { get; set; }
    }
}