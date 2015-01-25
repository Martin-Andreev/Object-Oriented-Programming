using System;

namespace _02.Enter_Numbers
{
    class EnterNumbersInRange
    {
        static void Main()
        {
            int start = 1;
            int end = 99;
            int counter = 9;

            for (int i = 0; i < 10; i++)
            {
                end = 99 - counter;
                
                bool isValid = false;
                
                do
                {
                    Console.Write("Number {0}: ", i + 1);
                    try
                    {
                        start = ReadNumber(start, end);
                        counter--;
                        isValid = true;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Try again! Your number must be in range {0} - {1}", start + 1, end);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid number!");
                    }
                } while (!isValid);
            }
        }

        private static int ReadNumber(int start, int end)
        {
            int number = 0;
            number = int.Parse(Console.ReadLine());
            if (number <= start || number > end)
            {
                throw new ArgumentOutOfRangeException();
            }

            return number;
        }
    }
}