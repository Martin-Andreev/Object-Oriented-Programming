namespace Company_Hierarchy.Models
{
    using System;
    using Company_Hierarchy.Enumerations;

    class Project
    {
        private string productName;
        private DateTime projectStartDate;
        private string details;
        private State state;

        public Project(string productName, DateTime projectStartDate, string details, State state)
        {
            this.ProductName = productName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.State = state;
        }
        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name cannot be null or empty!");
                }
                this.productName = value;
            }
        }

        public DateTime ProjectStartDate { get; set; }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Details cannot be null or empty!");
                }
                this.details = value;
            }
        }

        public State State{ get; set; }

        public void CloseProject()
        {
            this.State = State.Closed;
        }

        public override string ToString()
        {
            return string.Format("{0} - state: {1}. Project start date: {2}. Details: {3}", 
                this.ProductName, this.State, this.ProjectStartDate, this.Details);
        }
    }
}
