using System;
using System.IO;

namespace PrintFace
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Hello, world!{0}", Environment.NewLine);
            string userName = Console.ReadLine();
            SayHelloUser(userName);
            PrintFace();
        }

        public static void SayHelloUser(string userName)
        {
            Console.WriteLine("Hello, {0}!", userName);
        }

        public static void PrintFace()
        {
            Console.Write($" +\"\"\"\"\"+{Environment.NewLine}" +
                              $"(| o o |){Environment.NewLine}" +
                              $" |  ^  |{Environment.NewLine}" +
                              $" | '-' |{Environment.NewLine}" +
                              $" +-----+{Environment.NewLine}");
        }
    }
}
