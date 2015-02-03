namespace Animals
{
    using System;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null || value.Trim() == "")
                {
                    throw new ArgumentNullException("Name cannot be emtpy!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Age cannot be negative number!");
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (value == null || value.Trim() == "")
                {
                    throw new ArgumentNullException("Gender cannot be emtpy!");
                }
                this.gender = value;
            }
        }

        public abstract void ProduceSound();
    }
}
