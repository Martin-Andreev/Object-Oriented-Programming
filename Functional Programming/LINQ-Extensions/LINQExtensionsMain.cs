namespace LINQ_Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LINQExtensionsMain
    {
        public static void Main()
        {
            List<string> names = new List<string>() { "antonio", "asparuh", "garibaldi", "gergin", "mitko", "minko", "petko" };
            Console.WriteLine("All names: ");
            names.ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\n\nOnly names that do not start with 'P' or 'A': ");
            names
                .WhereNot(x => x.StartsWith("p") || x.StartsWith("a"))
                .ToList()
                .ForEach(x => Console.WriteLine(x + " "));

            Console.WriteLine("\nRepeating the collection 'n' times:");
            names
                .Repeat(2)
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            List<string> suffixes = new List<string>() { "ko", "o", "slav", "in" };
            Console.WriteLine("\nOnly names that end with 'ko', 'slav', 'in':");
            names
                .WhereEndsWith(suffixes)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
