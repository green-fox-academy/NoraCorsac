using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailycodinghours = 6;
            int numberofweeks = 17;
            int workdays = 5;
            int d;
            double e;

            d = dailycodinghours * numberofweeks * workdays;
            Console.WriteLine("An average Green Fox attendee is spent with coding in a semester {0} hours, if the attendee only codes on workdays.", d);

            int weeklycodinghours = 52;

            e = 30 / (double) weeklycodinghours * 100;
            Console.WriteLine("The percentage of coding hours in the semester is {0} %, if the average work hurs weekly is 52.", e);

            Console.ReadLine();
          
         
        }
    }
}