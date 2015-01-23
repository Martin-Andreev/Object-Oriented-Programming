using System;

namespace _04.Software_University_Learning_System
{
    class Student : Person
    {
        private uint studentNumber;
        private double avgGrade;

        public Student(string firstName, string lastName, byte age, uint studentNumber, double avgGrade)
            :base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AvgGrade = avgGrade;
        }

        public uint StudentNumber
        {
            get { return this.studentNumber; }
            set 
            {
                if (value >  4200000000)
                {
                    throw new ArgumentOutOfRangeException("Student number must be in range 0...4200000000!");
                }
                this.studentNumber = value;
            }
        }

        public double AvgGrade
        {
            get { return this.avgGrade; }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Student average graed must be in range 2...6!");
                }
                this.avgGrade = value;
            }
        }
    }
}
