using System;

namespace _04.Software_University_Learning_System
{
    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, byte age)
            :base(firstName, lastName, age)
        {
        }

        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("{0} course has been deleted by {1} {2}!\n", courseName, this.FirstName, this.LastName);
        }
    }
}
