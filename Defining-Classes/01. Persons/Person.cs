using System;

namespace _01.Person
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 1 and 100");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value == null || (value.Length > 0 && value.Contains("@")))
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Invalid e-mail!");
                }
            }
        }

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        public override string ToString()
        {
            return string.Format("My name is {0} and I am {1} years old! My e-mail is {2}", this.name, this.age, this.email ?? "unknown");
        }


    }
}
