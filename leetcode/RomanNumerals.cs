using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Solution
    {
        // Given nums = [11, 7, 2, 15], target = 9
        // return [0, 1].

        // Given nums = [5, 5, 11, 8] target = 19
        // return [2, 3].

        public int RomanToInt(string s)
        {
            IDictionary<string, int> numerals = new Dictionary<string, int>();
            numerals.Add("I", 1);
            numerals.Add("V", 5);
            numerals.Add("X", 10);
            numerals.Add("L", 50);
            numerals.Add("C", 100);
            numerals.Add("D", 500);
            numerals.Add("M", 1000);

            return 1;
        }

        static void Main(string[] args)
        {
            Console.Write("HI");
            do
            {
                while (!Console.KeyAvailable)
                {
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}