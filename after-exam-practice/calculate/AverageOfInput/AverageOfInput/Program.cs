using System;

namespace AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!\nIf you enter 5 integer in a row, I will tell you it's sum ant it's average.\nEnter the numbers here: ");

            string firstEnteredNumber = Console.ReadLine();
            int firstNumber = int.Parse(firstEnteredNumber);
            string secondEnteredNumber = Console.ReadLine();
            int secondNumber = int.Parse(secondEnteredNumber);
            string thirdEnteredNumber = Console.ReadLine();
            int thirdNumber = int.Parse(thirdEnteredNumber);
            string fourthEnteredNumber = Console.ReadLine();
            int fourthNumber = int.Parse(fourthEnteredNumber);
            string fifthEnteredNumber = Console.ReadLine();
            int fifthNumber = int.Parse(fifthEnteredNumber);

            int sumOfNumbers = firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber;
            double averageOfNumbers = sumOfNumbers / 5;

            Console.WriteLine("Your number's sum is: {0}, and it's average is: {1}.", sumOfNumbers , averageOfNumbers);
            Console.ReadLine();

        }
    }
}
