namespace String_Disperser
{
    using System;

    public class StringDisperserMain
    {
        public static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("Gosho", "Pesho", "Tanio");
            Console.WriteLine(stringDisperser.ToString());
            Console.WriteLine("Hash code: " + stringDisperser.GetHashCode());

            StringDisperser otherDisperser = new StringDisperser("Stefan, Genadi, Strahil, Ognian");
            Console.WriteLine(otherDisperser.CompareTo(stringDisperser));
            Console.WriteLine(otherDisperser.Equals(stringDisperser));

            StringDisperser stringDisperserClone = (StringDisperser)stringDisperser.Clone();
            Console.WriteLine(stringDisperser.Equals(stringDisperserClone));
            Console.WriteLine(stringDisperser == otherDisperser);

            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }
        }
    }
}
