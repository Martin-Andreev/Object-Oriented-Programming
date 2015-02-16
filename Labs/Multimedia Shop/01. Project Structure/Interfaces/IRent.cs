namespace MultimediaShop.Interfaces
{
    using System;
    using MultimediaShop.Enumerations;
    using MultimediaShop.Models;

    public interface IRent
    {
        IItem Item { get; set; }

        RentState RentState { get; }
        
        DateTime RentDate { get; set; }
        
        DateTime Deadline { get; set; }
        
        DateTime ReturnDate { get; set; }

        decimal RentFine();
    }
}