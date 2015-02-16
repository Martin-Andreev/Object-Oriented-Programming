namespace MultimediaShop.Models.Items
{
    using System;
    using System.Collections.Generic;

    public class Book : Item
    {
        private string author;

        public Book(string id, string title, decimal price, string author, List<string> genres)
            : base(id, title, price, genres)
        {
            this.Author = author;
        }

        public Book(string id, string title, decimal price, string author, string genre)
            : base(id, title, price, genre)
        {
            this.Author = author;
        }

        public string Author
        {
            get
            {
                return this.author;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Author cannot be emtpy!");
                }
                
                this.author = value;
            }
        }
    }
}