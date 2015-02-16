namespace MultimediaShop.CoreLogic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MultimediaShop.Enumerations;
    using MultimediaShop.Interfaces;
    using MultimediaShop.Models.Items;

    public static class SupplyManager
    {
        private static Dictionary<IItem, int> supplies = new Dictionary<IItem, int>();

        public static Dictionary<IItem, int> Supplies
        {
            get
            {
                return SupplyManager.supplies;
            }
        }

        public static void ProcessSupplyCommand(string[] pairsParams)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            string[] pairs = pairsParams[3].Split('&');
            foreach (var pair in pairs)
            {
                string[] keyValuePair = pair.Split('=');
                keyValuePairs[keyValuePair[0]] = keyValuePair[1];
            }

            string itemType = pairsParams[1];
            int quantity = int.Parse(pairsParams[2]);
            CreateItemToSupply(keyValuePairs, itemType, quantity);
        }

        public static void CreateItemToSupply(Dictionary<string, string> item, string itemType, int quantity)
        {
            IItem itemToSupply = null;
            switch (itemType)
            {
                case "book":
                    itemToSupply = new Book(
                        item["id"],
                        item["title"],
                        decimal.Parse(item["price"]),
                        item["author"],
                        item["genre"]);
                    break;

                case "game":
                    AgeRestriction ageRestriction = (AgeRestriction)Enum.Parse(typeof(AgeRestriction), item["ageRestriction"]);
                    itemToSupply = new Game(
                        item["id"],
                        item["title"],
                        decimal.Parse(item["price"]),
                        item["genre"],
                        ageRestriction);
                    break;

                case "video":
                    itemToSupply = new Video(
                        item["id"],
                        item["title"],
                        decimal.Parse(item["price"]),
                        double.Parse(item["length"]),
                        item["genre"]);
                    break;
            }

            AddToSupply(itemToSupply, quantity);
        }

        public static void AddToSupply(IItem item, int quantity)
        {
            SupplyItem(item, quantity);
        }

        public static void SupplyItem(IItem item, int quantity)
        {
            IItem[] equalItems = SupplyManager.Supplies.Keys.Where(k => k.ID == item.ID).ToArray();
            if (equalItems.Length > 0)
            {
                Supplies[equalItems.First()] += quantity;    
            }
            else
            {
                Supplies.Add(item, quantity);
            }
        }

        public static IItem GetElementById(string id)
        {
            foreach (var item in SupplyManager.Supplies)
            {
                if (item.Key.ID == id)
                {
                    return item.Key;
                }
            }

            return null;
        }
    }
}
