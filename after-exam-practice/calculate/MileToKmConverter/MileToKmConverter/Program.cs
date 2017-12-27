using System;

namespace MileToKmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the distance in km: ");
            string distance = Console.ReadLine();
            int km = int.Parse(distance);
            double mile = km * 0.621371192;
            Console.WriteLine("The distance is {0} mile.", mile);
            Console.ReadLine();
        }
    }
}
