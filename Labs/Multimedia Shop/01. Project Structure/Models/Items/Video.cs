namespace MultimediaShop.Models.Items
{
    using System;
    using System.Collections.Generic;

    public class Video : Item
    {
        private double length;

        public Video(string id, string title, decimal price, double length, List<string> genres)
            : base(id, title, price, genres)
        {
            this.Length = length;
        }

        public Video(string id, string title, decimal price, double length, string genre)
            : base(id, title, price, genre)
        {
            this.Length = length;
        }

        public double Length
        {
            get
            {
                return this.length;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Video length cannot be negative number!");
                }

                this.length = value;
            }
        }
    }
}
