using System;
using System.Text;

namespace ConsoleApp1
{
    class Kata
    {
        public static bool isDivisible(long n, long x, long y)
        {
            if (n <= 0 || x <= 0 || y <= 0)
            {
                throw new ArgumentException("entries must be greater than 0");
            }

            if ((n % x) == 0 && (n % y) == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isDivisible(24,4,6));

            do
            {
                while (!Console.KeyAvailable)
                {
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}