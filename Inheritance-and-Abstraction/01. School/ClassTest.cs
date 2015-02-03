namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    class ClassTest
    {
        public static void Main()
        {
            Student bobev = new Student("Bobev", 9, "Musician");
            Student irina = new Student("Irina", 13, "Talanted, Lazy");
            Student martin = new Student("Martin", 7, "Fighter");
            Student gosho = new Student("Gosho", 11, "Very clever");
            Student rumen = new Student("Rumen", 21, "Programmer");
            Student pesho = new Student("Pesho", 15, "Lazy");
            Student didka = new Student("Didka", 1, "Noisy");

            List<Student> itStudents = new List<Student>() { bobev, rumen };
            List<Student> engStudents = new List<Student>() { martin, irina };
            List<Student> musicStudents = new List<Student>() { didka, pesho, gosho };

            Discipline it = new Discipline("IT", 8, itStudents, "Advance C#");
            Discipline english = new Discipline("English", 15, engStudents, "Basics");
            Discipline music = new Discipline("Music", 5, musicStudents);

            Teacher petko = new Teacher("Petko", new List<Discipline>() { it, english });
            Teacher dako = new Teacher("Dako", new List<Discipline>() { music });

            Class class1 = new Class("11 V", new List<Teacher>() { petko, dako }, 
                new List<Student>() { irina, martin, rumen, bobev }, "Noisy class");
        }
    }
}
