namespace MultimediaShop.CoreLogic
{
    using System;
    using System.Linq;
    using MultimediaShop.Enumerations;

    public static class ReportManager
    {
        public static void ProcessReportCommand(string[] pairsParams, string reportCommand)
        {
            switch (reportCommand)
            {
                case "rents":
                    ReportRents();
                    break;

                case "sales":
                    DateTime startDate = DateTime.Parse(pairsParams[2]);
                    ReportSales(startDate);
                    break;

                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }

        public static void ReportSales(DateTime startDate)
        {
            var outputSaleReport = SaleManager.Sales
               .Select(s => s)
               .Where(s => s.SaleDate > startDate)
               .OrderBy(s => s.Item.Title);
            decimal allItemSum = 0;
            foreach (var item in outputSaleReport)
            {
                allItemSum += item.Item.Price;
            }

            Console.WriteLine(allItemSum);
        }

        public static void ReportRents()
        {
            var outputRentReport = RentManager.Rents
                .Select(rent => rent)
                .Where(rent => rent.RentState == RentState.Overdue)
                .OrderBy(rent => rent.RentFine())
                .ThenBy(rent => rent.Item.Title);

            foreach (var item in outputRentReport)
            {
                Console.WriteLine(item);
            }
        }
    }
}
