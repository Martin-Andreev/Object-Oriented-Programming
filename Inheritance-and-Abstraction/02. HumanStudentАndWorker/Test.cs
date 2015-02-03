namespace HumanStudentАndWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Test
    {
        static void Main()
        {
            Student bobev = new Student("Remi", "Bobev", "112134");
            Student irina = new Student("Irina", "Bachvarova", "45123456");
            Student rumen = new Student("Rumen", "Tsonkov", "5123551");
            Student dilyana = new Student("Dilyana", "Dimitrova", "651114551");
            Student kubrat = new Student("Kubrat", "Pulev", "5123512");
            Student martin = new Student("Martin", "Andreev", "237124411");
            Student nenko = new Student("Nenko", "Andreev", "1234971");
            Student tervel = new Student("Tervel", "Pulev", "85941234");
            Student asen = new Student("Asen", "Raztsvetnikov", "55115555");
            Student ivaylo = new Student("Ivaylo", "Petrov", "95912395");
            Student simeon = new Student("Simeon", "Velikii", "73102311");

            List<Student> students = new List<Student>() { bobev, irina, rumen, dilyana, kubrat,
                martin, nenko, tervel, asen, ivaylo, simeon };

            var studentsResult = from student in students
                                 orderby student.FacultyNumber
                                 select student;

            Console.WriteLine("Student sorted by faculty number:");
            foreach (var student in studentsResult)
            {
                Console.WriteLine("   Faculty number: {0} - {1} {2}",
                    student.FacultyNumber, student.FirstName, student.LastName);
            }

            Worker kiro = new Worker("Kiril", "Lalov", 320, 8);
            Worker plamen = new Worker("Plamen", "Radichkov", 100, 8);
            Worker kristina = new Worker("Kristina", "Kiurkchieva", 100, 4);
            Worker wayne = new Worker("Wayne", "Rooney", 783000, 8);
            Worker asparuh = new Worker("Asparuh", "Nikodimov", 550, 8);
            Worker walter = new Worker("Walter", "White", 1000000, 5);
            Worker michael = new Worker("Michael", "Scofield", 1500, 8);
            Worker jesse = new Worker("Jesse", "Pinkman", 815000, 5);
            Worker piro = new Worker("Piro", "Makedonski", 150, 7);
            Worker goshow = new Worker("Goshow", "Loshow", 200, 6);

            List<Worker> workers = new List<Worker>() { kiro, plamen, kristina, wayne, asparuh, 
                walter, michael, jesse, piro, goshow };

            var workersResult = from worker in workers
                                orderby worker.MoneyPerHour()
                                select worker;

            Console.WriteLine("\nWorkers sorted by payment per hour:");
            foreach (var worker in workersResult)
            {
                Console.WriteLine("   Payment per hour: {0} - {1} {2}" ,
                    worker.MoneyPerHour(), worker.FirstName, worker.LastName);
            }

            var humans = students.Cast<Human>().Concat(workers.Cast<Human>());

            var result = from human in humans
                         orderby human.FirstName, human.LastName
                         select human;

            Console.WriteLine("\nAll people sorted by first name and last name:");
            foreach (var human in result)
            {
                Console.WriteLine("   {0} {1}", human.FirstName, human.LastName);
            }
        }
    }
}
