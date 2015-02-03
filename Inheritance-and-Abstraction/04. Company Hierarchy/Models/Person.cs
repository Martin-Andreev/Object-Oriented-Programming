namespace Company_Hierarchy.Models
{
    using System;
    using Company_Hierarchy.Contracts;

    public abstract class Person : IPerson
    {
        private uint id;
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName, uint id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Id = id;
        }

        public uint Id { get; set; }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(firstName))
                {
                    throw new ArgumentNullException("First name cannot be null or empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(lastName))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} --> id: {2}.", this.FirstName, this.LastName, this.Id);
        }
    }
}
