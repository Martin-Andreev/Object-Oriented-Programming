using System;

namespace _01.Person
{
    class Persons
    {
        static void Main()
        {
            Person asparuh = new Person("Asparuh Asparuhov", 21);
            Person nezabravka = new Person("Nezabravka Zabravimova", 35, "neziztoo@sexymace.com");

            Console.WriteLine(asparuh.ToString());
            Console.WriteLine(nezabravka.ToString());
        }
    }
}