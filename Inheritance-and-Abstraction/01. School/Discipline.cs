namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    public class Discipline : IDetail
    {
        private string name;
        private int numberOfLectures;
        private string details;
        private IList<Student> students;

        public Discipline(string name, int numberOfLectures, IList<Student> students, string details = null)
        {
            this.Name = name;
            this.NumberOfLecture = numberOfLectures;
            this.Students = students;
            this.Details = details;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public int NumberOfLecture
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of lectures cannot be negative number!");
                }
                this.numberOfLectures = value;
            }
        }

        public IList<Student> Students
        {
            get { return this.students; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Students can not be null!");
                }

                this.students = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentNullException("Details cannot be empty value!");
                }
                this.details = value;
            }
        }
    }
}
