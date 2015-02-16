namespace ClassStudent
{
    using System;

    public class StudentSpecialty
    {
        private string specialtyName;
        private int facultyNumber;

        public StudentSpecialty(string specialtyName, int facultyNumber)
        {
            this.SpecialtyName = specialtyName;
            this.FacultyNumber = facultyNumber;
        }

        public string SpecialtyName
        {
            get
            {
                return this.specialtyName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Specialty name can not be null or empty!");
                }

                this.specialtyName = value;
            }
        }

        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Faculty number can not be negative number!");
                }

                this.facultyNumber = value;
            }
        }
    }
}
