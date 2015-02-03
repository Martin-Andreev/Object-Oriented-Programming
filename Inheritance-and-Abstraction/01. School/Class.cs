namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Class : IDetail
    {
        private string uniqueTextIdentifier;
        private string details;
        private IList<Teacher> teachers;
        private IList<Student> students;

        public Class(string uniqueTextIdentifier, IList<Teacher> teacher, IList<Student> students, string details = null)
        {
            this.UniqueTextIdentifier = uniqueTextIdentifier;
            this.Teachers = teacher;
            this.Details = details;
            this.Students = students;
        }
        public string UniqueTextIdentifier
        {
            get { return this.uniqueTextIdentifier; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Unique text identifier cannot empty!");
                }
                this.uniqueTextIdentifier = value;
            }
        }

        public IList<Teacher> Teachers
        {
            get { return this.teachers; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Teachers can not be null");
                }

                this.teachers = value;
            }
        }

        public IList<Student> Students
        {
            get { return this.students; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Students can not be null");
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

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Class: " + this.UniqueTextIdentifier);


            return stringBuilder.ToString();

            //return "Дисциплина: " + this.Name + "\n  " +
            //string.Join("  ", this.students.Select(s => s.ToString() + "\n").ToArray());
        }

    }
}
