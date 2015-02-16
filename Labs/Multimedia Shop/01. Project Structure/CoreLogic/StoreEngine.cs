namespace MultimediaShop.CoreLogic
{
    using System;
    using System.Collections.Generic;
    using MultimediaShop.Enumerations;
    using MultimediaShop.Interfaces;
    using MultimediaShop.Models;
    using MultimediaShop.Models.Items;

    public class StoreEngine
    {
        public void Run()
        {
            while (true)
            {
                string command = Console.ReadLine();
                this.RouteCommand(command);
            }
        }

        public void RouteCommand(string paramsString)
        {
            string[] pairsParams = paramsString.Split(' ');
            string command = pairsParams[0];

            switch (command)
            {
                case "supply":
                    SupplyManager.ProcessSupplyCommand(pairsParams);
                    break;

                case "sell":
                    SaleManager.AddSale(pairsParams);
                    break;

                case "rent":
                    RentManager.AddRent(pairsParams);
                    break;

                case "report":
                    string reportCommand = pairsParams[1];
                    ReportManager.ProcessReportCommand(pairsParams, reportCommand);
                    break;

                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }
    }
}