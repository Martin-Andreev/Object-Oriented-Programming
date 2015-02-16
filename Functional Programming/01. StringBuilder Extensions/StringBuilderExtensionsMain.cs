namespace StringBuilderExtensions
{
    using System;
    using System.Text;

    public class StringBuilderExtensionsMain
    {
        public static void Main()
        {
            StringBuilder test = new StringBuilder("This is my test for the first task.");
            Console.WriteLine(test.ToString());
            Console.WriteLine(test.Substring(24, 10));
            Console.WriteLine(test.RemoveText("THIS IS "));
            Console.WriteLine(test.AppendAll(new string[] { " New", " ", "extension", " ", "test" }));
        }
    }
}
