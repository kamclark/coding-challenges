using System;
using System.Text;

namespace ConsoleApp1
{
    class Kata
    {

        public static string NoSpace(string input)
        {
            string noSpaces = "";

            foreach (var z in input)
            {
                if (z !=  ' ')
                {
                    noSpaces = noSpaces + z;
                }

            }

            Console.WriteLine(noSpaces);
            return noSpaces;
        }

        static void Main(string[] args)
        {
            string array = "A beautiful picture of a waterfall (by Jeffrey Workman).";
            NoSpace(array);

            do
            {
                while (!Console.KeyAvailable)
                {
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}