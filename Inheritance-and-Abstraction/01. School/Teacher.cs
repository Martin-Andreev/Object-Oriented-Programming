namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Teacher : Person
    {
        private IList<Discipline> disciplines;
        public Teacher(string name, List<Discipline> disciplines, string details = null)
            : base(name, details)
        {
            this.Disciplines = disciplines;
        }

        public List<Discipline> Disciplines
        {
            get 
            {
                return new List<Discipline>(this.disciplines); 
            }
            set { this.disciplines = value; }
        }
    }
}
