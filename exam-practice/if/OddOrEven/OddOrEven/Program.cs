using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!\nPlease enter a number, and I will tell you, this number is odd or even!\nThe number: ");
            string usersNumber = Console.ReadLine();
            int userNumber = int.Parse(usersNumber);

            if (userNumber % 2 == 0)
            {
                Console.WriteLine("Hurray! Your number is even!");
            }
            else
            {
                Console.WriteLine("Hurray! Your number is odd!");
            }
            Console.ReadLine();
        }
    }
}
