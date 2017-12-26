using System;

namespace CodingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            double dailyCodingHours = 6;
            int weeksInSemester = 17;
            double workDays = 5;
            double weeklyWorkHours = 52;

            double attendeeCodingHours = weeksInSemester * workDays * dailyCodingHours;
            double percentageCodingHours = dailyCodingHours * workDays / weeklyWorkHours * 100;
            Console.WriteLine("An average Green Fox Attendee is spent with coding in a semester {0} hours, if the attendee codes only on weekdays", attendeeCodingHours);
            Console.WriteLine("The percentage of the coding hours is {0} int the semester if the average work hours weekly is 52.", percentageCodingHours);
            Console.ReadLine();
        }
    }
}
