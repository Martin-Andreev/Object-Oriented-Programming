using System;
using System.Text;

namespace _04.Software_University_Learning_System
{
    class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, byte age, uint studentNumber, double avgGrade,
            string dropoutReason)
            :base(firstName, lastName, age, studentNumber, avgGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason
        {
            get { return this.dropoutReason; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Dropout reason cannot be empty!");
                }
                this.dropoutReason = value;
            }
        }

        public string Repply()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("First name: " + this.FirstName);
            sb.AppendLine("Last name: " + this.LastName);
            sb.AppendLine("Age: " + this.Age);
            sb.AppendLine("Student Number: " + this.StudentNumber);
            sb.AppendLine("Average grade: " + this.AvgGrade);
            sb.AppendLine("Dropout reason: " + this.DropoutReason);

            return sb.ToString();
        }
    }
}
