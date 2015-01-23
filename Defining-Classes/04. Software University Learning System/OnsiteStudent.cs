using System;

namespace _04.Software_University_Learning_System
{
    class OnsiteStudent : CurrentStudent
    {
        public OnsiteStudent(string firstName, string lastName, byte age, uint studentNumber, double avgGrade, 
            string currentCourse)
            :base(firstName, lastName, age, studentNumber, avgGrade, currentCourse)
        {  
        }
    }
}
