using System;
using System.Text;


namespace ConsoleApp1
{
    class Kata
    {

        public static string Remove_char(string s)
        {

            if (s.Length < 2)
            {
                throw new ArgumentException("length", "string should contain more than 2 characters");
            }

            string removed = s.Substring(1, s.Length - 2); // truncates from letter after first index to second to last letter
            return removed;
        }

        static void Main(string[] args)
        {
            string array = "abc";
            Console.WriteLine(Remove_char(array));


            do
            {
                while (!Console.KeyAvailable)
                {
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}