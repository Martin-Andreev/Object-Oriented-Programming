using System;

namespace _04.Software_University_Learning_System
{
    class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public OnsiteStudent(string firstName, string lastName, byte age, uint studentNumber, double avgGrade, 
            string currentCourse, int numberOfVisits)
            :base(firstName, lastName, age, studentNumber, avgGrade, currentCourse)
        {
            this.numberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits
        {
            get { return this.numberOfVisits; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of visits cannot be negative number!");
                }
                this.numberOfVisits = value;
            }
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("Number of visits for student {0} {1}: {2}\n",
                this.FirstName, this.LastName, this.numberOfVisits);

            return result;
        }
    }
}
