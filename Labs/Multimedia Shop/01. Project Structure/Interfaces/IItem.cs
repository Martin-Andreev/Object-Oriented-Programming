namespace MultimediaShop.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface IItem
    {
        string ID { get; }

        string Title { get; }

        decimal Price { get; }

        List<string> Genres { get; }
    }
}
