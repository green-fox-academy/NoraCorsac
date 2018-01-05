using System;

namespace OneTwoALot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!\nPlease write here your number: ");
            string inputNumber = Console.ReadLine();
            int userNumber = int.Parse(inputNumber);

            if (userNumber <= 0)
            {
                Console.WriteLine("Not enough!!");
            }
            else if (userNumber == 1)
            {
                Console.WriteLine("One");
            }
            else if (userNumber == 2)
            {
                Console.WriteLine("Two");
            }
            else
            {
                Console.WriteLine("A lot");
            }
            Console.ReadLine();
        }
    }
}
