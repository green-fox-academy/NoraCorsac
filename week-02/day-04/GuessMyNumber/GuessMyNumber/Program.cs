using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Random random = new Random();
                int numberToGuess = random.Next(100) + 1;
                int userGuess = 0;

                while (userGuess != numberToGuess)
                {
                    Console.Write("I've the number between 1-100.\nEnter your guess: ");
                    int.TryParse(Console.ReadLine(), out userGuess);

                    if (userGuess > numberToGuess)
                    {
                        Console.WriteLine("{0} is too high!", userGuess);
                    }
                    else if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("{0} is too low!", userGuess);
                    }
                    else
                    {
                        Console.WriteLine("{0} is right! Congratulations.", userGuess);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}