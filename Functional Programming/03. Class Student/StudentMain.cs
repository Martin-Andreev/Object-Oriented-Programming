namespace ClassStudent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentMain
    {
        public static void Main()
        {
            Student donald = new Student("Donald", "Duck", 21, 22013514, "+359881234567", "ducky@abv.bg",
                new List<int>() { 2, 3, 4, 5, 6 }, "Sofia", 2);
            Student vasko = new Student("Vasko", "Vasilev", 25, 22012615, "02 356 600", "vasil61@gmail.com",
                new List<int>() { 5, 3, 5, 5, 4 }, "Varna", 1);
            Student marko = new Student("Marko", "Polo", 30, 22013913, "+359887654321", "magarko@gmail.com",
                new List<int>() { 5, 5, 4, 2, 2 }, "Plovdiv", 2);
            Student micky = new Student("Micky", "Mouse", 20, 22011010, "+359 2 101 101", "mickyto@gmail.com",
                new List<int>() { 6, 6, 6, 5, 6 }, "Varna", 2);
            Student petrana = new Student("Petrana", "Ivanova", 19, 22013014, "+3592 812 091", "petrankaa@gmail.com",
                new List<int>() { 3, 2, 4, 2, 3 }, "Sofia", 1);
            Student irina = new Student("Irina", "Bachvarova", 18, 22014414, "+359886111011", "i.bachvarova@abv.bg",
                new List<int>() { 6, 5, 6, 4, 6 }, "Plovdiv", 1);

            List<Student> students = new List<Student>() { donald, marko, micky, petrana, vasko, irina };

            Console.Write("All students: ");
            students
                .ToList()
                .ForEach(x => Console.Write(x.FirstName + " "));

            Console.WriteLine("\n");

            // Problem 4: Print all students from group number 2.
            var studentsGroupeOne =
                from student in students
                where student.GroupNumber == 1
                orderby student.FirstName ascending
                select student;

            Console.WriteLine("All students from group 1:");
            studentsGroupeOne
                .ToList()
                .ForEach(s => Console.WriteLine(s));

            // Problem 5: Print all students whose first name is before their last name alphabetically. 
            var studentsAlphabetically =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            Console.WriteLine("All students whose first name is before their last name alphabetically:");
            studentsAlphabetically
                .ToList()
                .ForEach(s => Console.WriteLine(s));

            // Problem 6: Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. The query should return only the first name, last name and age.
            var studentsInRange =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select new { student.FirstName, student.LastName, student.Age };

            Console.WriteLine("All students with age between 18 and 24:");
            studentsInRange
                .ToList()
                .ForEach(s => Console.WriteLine("Student: {0} {1}. Age: {2}", s.FirstName, s.LastName, s.Age));
            Console.WriteLine();

            // Problem 7: Sort the students by first name and last name in descending order with lambda expressions and LINQ query.
            Console.WriteLine("Students sorted alphabetically in descending order:");
            students
                .OrderByDescending(s => s.FirstName)
                .ThenByDescending(s => s.LastName)
                .ToList()
                .ForEach(s => Console.WriteLine(s));

            var studentsDescending =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            // Problem 8: Print all students that have email @abv.bg.
            var studentsByEmail =
                from student in students
                where student.Email.EndsWith("@abv.bg")
                select student;

            Console.WriteLine("All students that have email @abv.bg:");
            studentsByEmail
                .ToList()
                .ForEach(s => Console.WriteLine(s));

            // Problem 9: Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). 
            var studentsBySofiaPhone =
                from student in students
                where student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") || student.Phone.StartsWith("+359 2")
                select student;

            Console.WriteLine("All students with phones in Sofia (starting with 02 / +3592 / +359 2):");
            studentsBySofiaPhone
                .ToList()
                .ForEach(s => Console.WriteLine(s));

            // Problem 10: Print all students that have at least one mark Excellent (6).
            var studentsByExcellence =
                from student in students
                where student.Marks.Contains(6)
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    Marks = student.Marks
                };

            Console.WriteLine("All students that have at least one mark Excellent (6):");
            studentsByExcellence
                .ToList()
                .ForEach(s => Console.WriteLine("Student: {0}. Marks: {1}", s.FullName, string.Join(", ", s.Marks)));

            // Problem 11: Extract the students with exactly two marks "2".
            var weakStudents =
                from student in students
                where student.Marks.Count(mark => mark == 2) == 2
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    Marks = student.Marks
                };

            Console.WriteLine("\nStudents with exactly two marks '2':");
            weakStudents
                .ToList()
                .ForEach(s => Console.WriteLine("Student: {0}. Marks: {1}", s.FullName, string.Join(", ", s.Marks)));

            // Problem 12: Extract and print the Marks of the students that enrolled in 2014 (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).
            var studentsFrom2014 =
                from student in students
                where student.FacultyNumber.ToString().EndsWith("14")
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    FacultyNumber = student.FacultyNumber,
                    Marks = student.Marks
                };

            Console.WriteLine("\nStudents that enrolled in 2014:");
            studentsFrom2014
                .ToList()
                .ForEach(s => Console.WriteLine("Student: {0}. Faculty number: {1}. Marks: {2}",
                    s.FullName, s.FacultyNumber, string.Join(", ", s.Marks)));

            // Problem 13: Write a program that extracts all students grouped by GroupName.
            var studentsByGroup =
                from student in students
                group student by student.GroupName into studentGroup
                select new
                {
                    GroupName = studentGroup.Key,
                    GroupMembers = studentGroup.ToList()
                };

            Console.WriteLine("\nStudents grouped by GroupName:");
            foreach (var group in studentsByGroup)
            {
                Console.WriteLine(group.GroupName);
                Console.WriteLine(string.Join("\n", group.GroupMembers));
            }

            // Problem 14: Create a class StudentSpecialty that holds specialty name and faculty number. Create a list of student specialties, where each specialty corresponds to a certain student (via the faculty number). Print all student names alphabetically along with their faculty number and specialty name.

            var specialties = new List<StudentSpecialty>()
            {
                new StudentSpecialty("Web Developer", 22014414),
                new StudentSpecialty("QA Developer", 22011010),
                new StudentSpecialty("QA Developer", 22013913),
                new StudentSpecialty(".Net Developer", 22014414),
                new StudentSpecialty("Web Designer", 22011010),
                new StudentSpecialty("Java Developer", 22012615)
            };

            var studentsBySpecialties =
                from specialty in specialties
                join student in students on specialty.FacultyNumber equals student.FacultyNumber
                orderby student.FirstName, student.LastName, specialty.SpecialtyName
                select new
                {
                    Name = student.FirstName + " " + student.LastName,
                    FacultyNumber = student.FacultyNumber,
                    Specialty = specialty.SpecialtyName
                };
            Console.WriteLine("Students by specialties:");
            studentsBySpecialties
                .ToList()
                .ForEach(s => Console.WriteLine("Student: {0}\nFaculty number: {1}\nSpecialty: {2}\n",
                    s.Name, s.FacultyNumber, s.Specialty));
        }
    }
}