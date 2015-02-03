namespace SchoolSystem
{
    using System;

    public class Student : Person
    {
        private uint uniqueClassNumber;

        public Student(string name, uint uniqueClassNumber, string details = null)
            : base(name, details)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public uint UniqueClassNumber
        {
            get { return this.uniqueClassNumber; }
            set { this.uniqueClassNumber = value; }
        }
    }
}