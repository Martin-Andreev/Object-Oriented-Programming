using System;

namespace _04.Software_University_Learning_System
{
    class GraduateStudent : Student
    {
        public GraduateStudent(string firstName, string lastName, byte age, uint studentNumber, double avgGrade)
            :base(firstName, lastName, age, studentNumber, avgGrade)
        {
        }
    }
}
