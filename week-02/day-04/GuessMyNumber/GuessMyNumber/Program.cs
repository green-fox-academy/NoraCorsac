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
                int lives = 4;
                Console.Write("I've the number between 1-100.\nEnter your first guess:");

                while (userGuess != numberToGuess || lives>0)
                {
                    int.TryParse(Console.ReadLine(), out userGuess);
                    if (lives > 0)
                    {
                        if (userGuess == numberToGuess && lives > 0)
                        {
                            Console.WriteLine("{0} is right! Congratulations.", userGuess);
                            Console.ReadLine();
                        }
                        if (userGuess > numberToGuess || lives > 0)
                        {
                            Console.WriteLine("{0} is too high! You lose a life.\nEnter your next guess:", userGuess);
                            lives--;
                        }
                        else
                        {
                            Console.WriteLine("{0} is too low! You lose a life.\nEnter your next guess:", userGuess);
                            lives--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you have no more lives. Game Over!");
                        Console.ReadLine();

                    }
                    
                    
                }
             
            }
            //Console.ReadLine();
        }
    }
}