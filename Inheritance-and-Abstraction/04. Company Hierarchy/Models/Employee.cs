namespace Company_Hierarchy.Models
{
    using System;
    using Company_Hierarchy.Contracts;
    using Company_Hierarchy.Enumerations;

    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;

        public Employee(string firstName, string lastName, uint id, decimal salary, Department department)
            :base(firstName, lastName, id)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                ushort minSalary = 360;
                if (value < minSalary)
                {
                    throw new ArgumentOutOfRangeException("The monthly wage must be at least 360lv.");
                }
                this.salary = value;
            }
        }

        public Department Department { get; set; }

        public override string ToString()
        {
            string employeeToString = base.ToString() + string.Format(" Salary: {0}lv. Department: {1}", 
                this.Salary, this.Department); 

            return employeeToString;
        }
    }
}
