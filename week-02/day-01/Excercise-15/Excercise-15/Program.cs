using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add the km:");
            string add = Console.ReadLine();
            int number = int.Parse(add);
            double miles = number / 1.621371192;

            Console.WriteLine("Thats {0} miles.", miles);
            Console.ReadLine();
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
        }
    }
}