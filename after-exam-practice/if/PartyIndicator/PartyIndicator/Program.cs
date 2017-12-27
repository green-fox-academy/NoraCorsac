using System;

namespace PartyIndicator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of girls: ");
            string boysinput = Console.ReadLine();
            int numberOfBoys = int.Parse(boysinput);

            Console.WriteLine("Please enter the number of boys: ");
            string girlsinput = Console.ReadLine();
            int numberOfGirls = int.Parse(girlsinput);

            int numberOfAll = (numberOfBoys + numberOfGirls);

            if (numberOfBoys == numberOfGirls && numberOfAll > 20)
            {
                Console.WriteLine("The party is excellent!");
            }
            else if ((numberOfBoys != numberOfGirls) && numberOfAll > 20)
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (numberOfAll <= 20)
            {
                Console.WriteLine("Average party...");
            }
            else if (numberOfGirls < 1)
            {
                Console.WriteLine("Sausage party...");
            }

            Console.ReadLine();
        }
    }
}
