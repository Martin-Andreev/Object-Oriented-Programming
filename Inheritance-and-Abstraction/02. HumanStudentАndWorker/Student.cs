namespace HumanStudentАndWorker
{
    using System;

    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string fautyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = fautyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value == null || value.Trim() == "")
                {
                    throw new ArgumentNullException("Faculty number cannot be null or empty!");
                }
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Faculty number must contains 5-10 letters!");
                }
                this.facultyNumber = value;
            }
        }
    }
}
