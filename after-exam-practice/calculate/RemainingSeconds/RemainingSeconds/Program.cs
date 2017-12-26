using System;

namespace RemainingSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int secondsInADay = 86400;
            int changeNumber = 60;

            int remainingSeconds = secondsInADay - (currentHours * changeNumber * changeNumber + currentMinutes * changeNumber + currentSeconds);
            Console.WriteLine("{0} seconds remaining.", remainingSeconds);
            Console.ReadLine();
        }
    }
}
