namespace Company_Hierarchy.Models
{
    using System;
    using Company_Hierarchy.Contracts;
    using System.Collections.Generic;
    using Company_Hierarchy.Enumerations;

    class Manager : Employee, IManager
    {
        private List<Employee> employees;

        public Manager(string firstName, string lastName, uint id, decimal salary, Department department, List<Employee> employees)
            :base(firstName, lastName, id, salary, department)
        {
            this.Employees = employees;
        }
        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
            string employeesString = "";
            foreach (var employee in this.Employees)
            {
                employeesString += employee;
            }

            return "Manager: " + base.ToString() + "\nEmployees under his command: " + employeesString;
        }
    }
}
