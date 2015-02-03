namespace Company_Hierarchy.Models
{
    using System;
    using System.Collections.Generic;
    using Company_Hierarchy.Contracts;
    using Company_Hierarchy.Enumerations;

    class Developer : Employee, IDeveloper
    {
        public Developer(string firstName, string lastName, uint id, decimal salary, Department department, List<Project> projects)
            :base(firstName, lastName, id, salary, department)
        {
            this.Projects = projects;
        }

        public List<Project> Projects { get; set; }

        public override string ToString()
        {
            string projectsString = "";
            foreach (var project in this.Projects)
            {
                projectsString += project;
            }

            return "Developer: " + base.ToString() + " Projects: " + projectsString;
        }
    }
}
