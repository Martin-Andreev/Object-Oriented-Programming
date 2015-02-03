namespace Company_Hierarchy.Models
{
    using System;
    using System.Collections.Generic;
    using Company_Hierarchy.Contracts;
    using Company_Hierarchy.Enumerations;

    class SalesEmployee : Employee, ISalesEmployee
    {
        private List<ISale> sales;

        public SalesEmployee(string firstName, string lastName, uint id, decimal salary, Department department, List<ISale> sales)
            : base(firstName, lastName, id, salary, department)
        {
            this.Sales = sales;
        }

        public List<ISale> Sales
        {
            get { return this.sales; }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Sales cannot be empty");
                }

                sales = value;
            }
        }

        public override string ToString()
        {
            string salesStringResult = "";

            foreach (var sale in this.Sales)
            {
                salesStringResult += "\n" + sale;
            }

            return "Sales Employee: " + base.ToString() + "\nSales: " + salesStringResult;
        }
    }
}
