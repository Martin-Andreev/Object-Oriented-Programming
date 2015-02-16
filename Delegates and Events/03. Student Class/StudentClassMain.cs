namespace StudentClass
{
    using System;

    class StudentClassMain
    {
        static void Main()
        {
            var student = new Student("Genadi", 2);
            student.Name = "Minka";
            student.Age = 26;

            var studen2 = new Student("Spaska", 20);
            studen2.Name = "Spas";
            studen2.Age = 28;

            var studen3 = new Student("Anton", 40);
            studen3.Name = "Antonia";
            studen3.Age = 22;
        }
    }
}
