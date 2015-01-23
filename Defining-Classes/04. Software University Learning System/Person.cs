using System;

namespace _04.Software_University_Learning_System
{
    class Person
    {
        private string firstName;
        private string lastName;
        private byte age;

        public Person(string firstName, string lastName, byte age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName 
        {
            get { return this.firstName; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be empty!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty!");
                }
                this.lastName = value;
            }
        }

        public byte Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative number!");
                }
                this.age = value;
            }
        }
    }
}
