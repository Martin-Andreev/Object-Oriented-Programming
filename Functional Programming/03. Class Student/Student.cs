namespace ClassStudent
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private int facultyNumer;
        private string phone;
        private string email;
        private IList<int> marks;
        private string groupName;
        private int groupNumber;

        public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, string groupName, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupName = groupName;
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty!");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age can not be negative number!");
                }

                this.age = value;
            }
        }

        public int FacultyNumber
        {
            get
            {
                return this.facultyNumer;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Faculty number can not be negative number!");
                }

                this.facultyNumer = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Phone number cannot be null or empty!");
                }

                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email cannot be null or empty!");
                }

                this.email = value;
            }
        }

        public IList<int> Marks
        {
            get
            {
                return this.marks;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Marks can not be null!");
                }

                foreach (var item in value)
                {
                    if (item < 2 || item > 6)
                    {
                        throw new ArgumentOutOfRangeException("All marks must be in range 2-6!");
                    }
                }

                this.marks = value;
            }
        }

        public string GroupName
        {
            get
            {
                return this.groupName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Group name can not be null or empty!");
                }

                this.groupName = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Group number can not be negative number!");
                }

                this.groupNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();
            studentInfo.AppendLine(string.Format("Student: {0} {1}", this.FirstName, this.LastName));
            studentInfo.AppendLine("Age: " + this.Age);
            studentInfo.AppendLine("Faculty number: " + this.FacultyNumber);
            studentInfo.AppendLine("Phone: " + this.Phone);
            studentInfo.AppendLine("Email: " + this.Email);
            studentInfo.AppendLine(string.Format("Marks: {0}", string.Join(", ", this.Marks)));
            studentInfo.AppendLine("Group number: " + this.GroupNumber);
            return studentInfo.ToString();
        }
    }
}

//public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
