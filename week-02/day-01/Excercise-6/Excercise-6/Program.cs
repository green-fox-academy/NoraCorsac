using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 17;
            int c = 5;
            int d;
            double e;

            d = a * b * c;
            Console.WriteLine("An average Green Fox attendee is spent with coding in a semester {0} hours, if the attendee only codes on workdays.", d);

            e = 30 / 52 * 100;
            Console.WriteLine("The percentage of coding hours in the semester is {0} %, if the average work hurs weekly is 52.", e);

            Console.ReadLine();
          
         
        }
    }
}