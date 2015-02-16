namespace MultimediaShop.CoreLogic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MultimediaShop.Exceptions;
    using MultimediaShop.Interfaces;
    using MultimediaShop.Models;

    public class RentManager
    {
        private static HashSet<IRent> rents = new HashSet<IRent>();

        public static HashSet<IRent> Rents
        {
            get { return RentManager.rents; }
        }

        public static void AddRent(string[] pairsParams)
        {
            string itemId = pairsParams[1];
            DateTime rentDate = DateTime.Parse(pairsParams[2]);
            DateTime deadline = DateTime.Parse(pairsParams[3]);
            IItem[] availableItems = SupplyManager.Supplies.Keys.Where(k => k.ID == itemId).ToArray();

            if (availableItems.Length > 0)
            {
                SupplyManager.Supplies[availableItems.First()]--;
            }
            else
            {
                throw new InsufficientSuppliesException();
            }

            IItem item = SupplyManager.GetElementById(itemId);

            Rents.Add(new Rent(item, rentDate, deadline));
        }
    }
}