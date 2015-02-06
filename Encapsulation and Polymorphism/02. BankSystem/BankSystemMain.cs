namespace BankSystem
{
    using System;
    using System.Collections.Generic;
    using BankSystem.Contracts;
    using BankSystem.Models;

    public class BankSystemMain
    {
        public static void Main()
        {
            ICustomer stamat = new IndividualCustomer("Stamat Minkov");
            ICustomer penka = new IndividualCustomer("Irina B.");
            ICustomer rumen = new IndividualCustomer("Rumen Umen");
            ICustomer trabant = new CompanyCustomer("Trabant Corporation");
            ICustomer pravetz = new CompanyCustomer("Pravetz Ltd");

            var stamatAccount = new DepositAccount(stamat, 4000, 2);
            var penkaAccount = new LoanAccount(penka, 650, 3.5);
            var pravetzAccount = new MortageAccount(pravetz, 1100, 2.3);
            
            List<IAccount> accounts = new List<IAccount>() { stamatAccount, penkaAccount, pravetzAccount };

            foreach (var account in accounts)
            {
                Console.WriteLine("Account name: {0} \nAccount type: {1}\nMoney in Kurtovo Konare Bank: {2}lv.\n", account.Customer.Name, account.GetType().Name, account.CalculateInterest(2));
            }

            stamatAccount.Deposit(500);
            stamatAccount.Withdraw(3000);

            pravetzAccount.Deposit(150000);
        }
    }
}
