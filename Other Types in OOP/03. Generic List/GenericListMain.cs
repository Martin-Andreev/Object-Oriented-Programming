namespace GenericList
{
    using System;
    using System.Collections.Generic;

    public class GenericListMain
    {
        public static void Main()
        {
            var list = new GenericList<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine(list[4]);
            list.Remove(4);
            list.Insert(3, 10);
            list.Insert(0, -199);
            Console.WriteLine(list.IndexOf(3));
            Console.WriteLine(list.Contains(10));
            Console.WriteLine(list.ToString());
            Console.WriteLine("Max number: " + list.Max());
            Console.WriteLine("Min number: " + list.Min());
            list.Clear();
            Console.WriteLine(list.ToString());
        }
    }
}
