namespace MultimediaShop.Models.Items
{
    using System;
    using System.Collections.Generic;
    using MultimediaShop.Enumerations;

    public class Game : Item
    {
        public Game(string id, string title, decimal price, List<string> genres, AgeRestriction ageRestriction = AgeRestriction.Minor)
            : base(id, title, price, genres)
        {
            this.AgeRestriction = ageRestriction;
        }

        public Game(string id, string title, decimal price, string genre, AgeRestriction ageRestriction = AgeRestriction.Minor)
            : base(id, title, price, genre)
        {
            this.AgeRestriction = ageRestriction;
        }

        public AgeRestriction AgeRestriction { get; set; }
    }
}
