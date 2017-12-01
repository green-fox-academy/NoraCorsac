using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add the number of chickens has the farmer: ");
            string chicken = Console.ReadLine();
            int chickenLegs = int.Parse(chicken) * 2;
            Console.WriteLine("Please add the number of pigs the farmer has: ");
            string pig = Console.ReadLine();
            int pigLegs = int.Parse(pig) * 4;
            int allLegs = chickenLegs + pigLegs;

            Console.WriteLine("The animals have {0} legs.", allLegs);
            Console.ReadLine();
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have
        }
    }
}