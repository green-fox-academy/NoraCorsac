using System;

namespace AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Farmer!\nHow many chickens do you have? Please enter here: ");
            string chickensInput = Console.ReadLine();
            int chickenLegs = int.Parse(chickensInput);

            Console.WriteLine("Great! And how many pigs do you have? Please enter that here too: ");
            string pigsInput = Console.ReadLine();
            int pigsLegs = int.Parse(pigsInput);

            int numberOfLegs = chickenLegs * 2 + pigsLegs * 4;
            Console.WriteLine("Sounds great! So your animals have {0} legs in all.", numberOfLegs);
            Console.ReadLine();
        }
    }
}
