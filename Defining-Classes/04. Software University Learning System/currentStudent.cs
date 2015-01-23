using System;
using System.Text;

namespace _04.Software_University_Learning_System
{
    class CurrentStudent : Student
    {
        private string currentCourse;

        public CurrentStudent(string firstName, string lastName, byte age, uint studentNumber, double avgGrade, 
            string currentCourse)
            :base(firstName, lastName, age, studentNumber, avgGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse
        {
            get { return this.currentCourse; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Student current course cannot be empty!");
                }
                this.currentCourse = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("First name: " + this.FirstName);
            sb.AppendLine("Last name: " + this.LastName);
            sb.AppendLine("Age: " + this.Age);
            sb.AppendLine("Student Number: " + this.StudentNumber);
            sb.AppendLine("Average grade: " + this.AvgGrade);
            sb.AppendLine("Current course: " + this.CurrentCourse);

            return sb.ToString();
        }
    }
}
