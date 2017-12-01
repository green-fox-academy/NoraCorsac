using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;
            int allHours = 24;
            int allMinutes = 60;
            int allSeconds = 60;

            int secondsADay = allHours * allMinutes * allSeconds;
            int secondsCurrent = currentHours * currentMinutes * currentSeconds;

            Console.WriteLine(secondsADay - secondsCurrent + " seconds remaining.");
            Console.ReadLine();

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented bt the variables
        }
    }
}