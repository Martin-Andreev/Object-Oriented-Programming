namespace Animals
{
    using System;
    using System.Linq;

    class AnimalsTest
    {
        static void Main()
        {
            Dog sharo = new Dog("Sharo", 7, "Male");
            Dog blacky = new Dog("Blacky", 6, "Male");

            Frog jaburana = new Frog("Jaburana", 1, "Female");
            Frog jabok = new Frog("Jabok", 2, "Male");

            Kitten susan = new Kitten("Susan", 5);
            Kitten choki = new Kitten("Chocki", 2);

            Tomcat tom = new Tomcat("Tom", 3);
            Tomcat pancho = new Tomcat("Pancho", 6);

            Animal[] animals = { sharo, blacky, jaburana, jabok, susan, choki, tom, pancho };

            var animalsAvgAge =
                from animal in animals
                group animal by animal.GetType() into animalGroups
                select new { Groupname = animalGroups.Key.Name, AverageAge = animalGroups.Average(a => a.Age) };

            foreach (var animal in animalsAvgAge)
            {
                Console.WriteLine("Animal group: {0}. Group average age: {1}", animal.Groupname, animal.AverageAge);
            }
        }
    }
}
