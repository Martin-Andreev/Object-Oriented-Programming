namespace SchoolSystem
{
    using System;

    public abstract class Person : IDetail
    {
        private string name;
        private string details;

        protected Person(string name, string details = null)
        {
            this.Details = details;
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentNullException("Details cannot be empty value!");
                }
                this.details = value;
            }
        }
    }
}
