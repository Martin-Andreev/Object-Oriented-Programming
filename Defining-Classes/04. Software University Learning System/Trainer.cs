using System;

namespace _04.Software_University_Learning_System
{
    class Trainer : Person
    {
        public Trainer(string firstName, string lastName, byte age)
            :base(firstName, lastName, age)
        {
        }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("{0} course has been added by {1} {2}!\n", courseName, this.FirstName, this.LastName);
        }
    }
}
