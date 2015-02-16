namespace MultimediaShop.Interfaces
{
    using System;
    using MultimediaShop.Models;

    public interface ISale
    {
        IItem Item { get; set; }

        DateTime SaleDate { get; set; }
    }
}
