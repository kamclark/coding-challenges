using System;
using System.Text;


namespace ConsoleApp1
{
    class Kata
    { 

        public static int SumTwoSmallestNumbers(int[] numbers)
        {

            if (numbers == null)
            {
                throw new ArgumentNullException("numbers");
            }

            if (numbers.Length < 2)
            {
                throw new ArgumentException("numbers", "The array must have at least two elements.");
            }

            var x = int.MaxValue;
            var y = int.MinValue;


            foreach (var z in numbers)
            {
                if (z < x)
                {
                    y = x;
                    x = z;
                }
                else if (z < y)
                {
                    y = z;
                }
            }

            return x + y;
        }

        static void Main(string[] args)
        {
            int[] array = { 19, 5, 42, 2, 77 };
            Console.WriteLine(SumTwoSmallestNumbers(array)); // returns 7 from 2 + 5


            do
            {
                while (!Console.KeyAvailable)
                {
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}