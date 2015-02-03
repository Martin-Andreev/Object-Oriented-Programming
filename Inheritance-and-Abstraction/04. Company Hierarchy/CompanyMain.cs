namespace Company_Hierarchy
{
    using System;
    using Company_Hierarchy.Models;
    using Company_Hierarchy.Enumerations;
    using Company_Hierarchy.Contracts;
    using System.Collections.Generic;

    class CompanyMain
    {
        static void Main()
        {
            Project fifa = new Project("FIFA", DateTime.Now, "Simulator", State.Open);
            Sale nba = new Sale("NBA", new DateTime(2014, 5, 6), 100m);

            Developer peshkata = new Developer("Pesho", "Mesho", 14, 3000m, Department.Production,
                new List<Project>() {fifa} );

            SalesEmployee tosheto = new SalesEmployee("Todor", "Tonchev", 101, 3050m, Department.Production, 
                new List<ISale>(){nba});

            List<Employee> production = new List<Employee>(){ peshkata };
            List<Employee> sales = new List<Employee>(){tosheto};

            Manager kiro = new Manager("Kiro", "Lalov", 712390191, 5000m, Department.Accounting, production);
            Manager stradimir = new Manager("Stradimir", "Stradov", 1239812, 4000m, Department.Sales, sales);

            List<Employee> employees = new List<Employee>() { peshkata, stradimir, kiro, tosheto };

            foreach (var person in employees)
            {
                Console.WriteLine(person.ToString() + "\n");
            }

            Customer martin = new Customer("Martin", "Andreev", 1, 500m);
            Console.WriteLine(martin.ToString() + "\n");

            Console.WriteLine(fifa.ToString() + "\n");
            Console.WriteLine();
        }
    }
}
