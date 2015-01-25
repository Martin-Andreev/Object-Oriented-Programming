using System;

namespace _01.Square_Root
{
    class SquareRoot
    {
        static void Main()
        {
            Console.Write("Input a number: ");

            try
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("The square root of {0} is {1}", num, Math.Sqrt(num));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
