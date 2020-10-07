using System;
using System.Text;

namespace ConsoleApp1
{
    class Kata
    {
        public static string Likes(string[] name)
        {
            // throw new NotImplementedException();
            string likeMessage = "";
            int othersLength = name.Length - 2;

            if (name == null)
            {
                return null;
            }


            else if (name.Length == 0)
            {
                likeMessage = "no one likes this";
                return likeMessage;
            }

            else if (name.Length == 1)
            {
                likeMessage = name[0] + " likes this";
                return likeMessage;
            }

            else if (name.Length == 2)
            {
                likeMessage = name[0] + " and " + name[1] + " like this";
                return likeMessage;
            }

            else if (name.Length == 3)
            {
                likeMessage = name[0] + ", " + name[1] + " and " + name[2] + " like this";
                return likeMessage;
            }

            else if (name.Length > 3)
            {
                likeMessage = name[0] + ", " + name[1] + " and " + othersLength.ToString() + " others like this";
                return likeMessage;
            }

            else
            {
                return "";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Likes(new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" }));
            Console.WriteLine(Kata.Likes(new string[] { "Sun"}));
            Console.WriteLine(Kata.Likes(new string[] { "Sun", "Sat" }));
            Console.WriteLine(Kata.Likes(new string[] { }));

            do
            {
                while (!Console.KeyAvailable)
                {
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}