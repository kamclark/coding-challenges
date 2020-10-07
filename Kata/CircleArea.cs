using System;
using System.Text;

namespace ConsoleApp1
{
    class Kata
    {
        public static double CalculateAreaOfCircle(string radius)
        {

            foreach (char c in radius)
            {
                if (!char.IsDigit(c) && c != '.')
                {
                    throw new ArgumentException("only numbers");
                }
            }

            if (double.Parse(radius) <=  0)
            {
                throw new ArgumentException("there is no circle");
            }

            double area = Math.Round((Math.PI) * Math.Pow(double.Parse(radius), 2), 2) ;

            return area;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateAreaOfCircle("number"));

            do
            {
                while (!Console.KeyAvailable)
                {
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}