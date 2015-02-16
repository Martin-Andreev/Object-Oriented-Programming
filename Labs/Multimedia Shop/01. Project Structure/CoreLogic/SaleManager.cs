namespace MultimediaShop.CoreLogic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MultimediaShop.Interfaces;
    using MultimediaShop.Enumerations;
    using MultimediaShop.Exceptions;
    using MultimediaShop.Models;
    using MultimediaShop.Models.Items;

    public static class SaleManager
    {
        private static HashSet<ISale> sales = new HashSet<ISale>();

        public static HashSet<ISale> Sales
        {
            get { return SaleManager.sales; }
        }

        public static void AddSale(string[] pairsParams)
        {
            string itemId = pairsParams[1];
            DateTime saleDate = DateTime.Parse(pairsParams[2]);
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

            Sales.Add(new Sale(item, saleDate));
        }
    }
}
