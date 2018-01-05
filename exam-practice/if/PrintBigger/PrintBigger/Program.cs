using System;

namespace PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!\nPlease enter two integer in a row, than I will tell you, which is the bigger!\nYour numbers: ");

            string firstInputNumber = Console.ReadLine();
            int firstNumber = int.Parse(firstInputNumber);
            string secondInputNumber = Console.ReadLine();
            int secondNumber = int.Parse(secondInputNumber);

            if (firstNumber == secondNumber)
            {
                Console.WriteLine("The numbers are equal!");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("{0} is smaller than {1}!", firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("{0} is bigger than {1}!", firstNumber, secondNumber);
            }
            Console.ReadLine();
        }
    }
}
