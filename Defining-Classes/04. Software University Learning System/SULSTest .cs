using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Software_University_Learning_System
{
    class Program
    {
        static void Main()
        {
            Trainer nikolay = new Trainer("Nikolay", "Velkov", 31);
            Trainer irina = new Trainer("Irina", "Bachvarova", 20);

            JuniorTrainer evgeni = new JuniorTrainer("Evgeni", "Ivanov", 31);
            JuniorTrainer lubo = new JuniorTrainer("Luboslav", "Genov", 24);

            SeniorTrainer dilyna = new SeniorTrainer("Dilyna", "Dimitrova", 21);
            SeniorTrainer donka = new SeniorTrainer("Donka", "Chardakova", 45);

            Student rumen = new Student("Rumen", "Tsonkov", 21, 103, 6.00);
            Student martin = new Student("Martin", "Andreev", 21, 201, 5.92);

            GraduateStudent remi = new GraduateStudent("Remi", "Bobev", 22, 491, 5.56);
            GraduateStudent marko = new GraduateStudent("Marko", "Markov", 28, 14, 4.93);

            CurrentStudent radoslava = new CurrentStudent("Radoslava", "Katzarova", 30, 290, 4.71, "OOP");
            CurrentStudent kiril = new CurrentStudent("Kiril", "Lalov", 34, 100, 5.81, "AngularJS");

            DropoutStudent plamen = new DropoutStudent("Plamen", "Radichkov", 20, 89, 5.20, "Fight with trainer!");
            DropoutStudent petko = new DropoutStudent("Petko", "Neshev", 42, 35, 3.70, "Alcohol distribution!");

            OnlineStudent teodora = new OnlineStudent("Teodora", "Lazarova", 17, 800, 5.50, "OOP");
            OnlineStudent silvia = new OnlineStudent("Silvia", "Varbanova", 22, 454, 4.60, "Databases");

            OnsiteStudent nenko = new OnsiteStudent("Nenkov", "Andreev", 32, 303, 5.05, "Databases");
            OnsiteStudent ivan = new OnsiteStudent("Ivan", "Babachev", 22, 1, 5.90, "ASP.NET MVC");

            irina.CreateCourse("Web Services & Cloud");
            nikolay.CreateCourse("Web Development Basics");
            dilyna.DeleteCourse("Web Services & Cloud");
            donka.CreateCourse("Database Applications");

            List<Person> persons = new List<Person>() { nikolay, irina, evgeni, lubo, dilyna, donka, rumen, martin,
                remi, marko, radoslava, kiril, plamen, petko, teodora, silvia, nenko, ivan};

            //Sort with LINQ
            var output = from person in persons
                         where person is CurrentStudent
                         orderby ((Student)person).AvgGrade ascending
                         select person;

            foreach (var p in output)
            {
                Console.WriteLine(p);
            }

            //Sort with lambda expression:
            //persons
            //    .Where(person => person is CurrentStudent)
            //    .OrderBy(person => ((Student)person).AvgGrade).ToList()
            //    .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
