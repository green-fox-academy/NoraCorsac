using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add your number: ");
            string input = Console.ReadLine();
            int inputNumber = int.Parse(input);
            Console.WriteLine(Factorio(inputNumber));
            Console.ReadLine();
        }
        public static int Factorio(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
