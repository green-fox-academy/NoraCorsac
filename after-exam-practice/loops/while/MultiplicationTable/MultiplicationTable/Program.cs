using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the multiplicand number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int multiplicationNumber = 1;

            while (multiplicationNumber <= 10)
            {
                Console.WriteLine("{0} * {1} = {2}", multiplicationNumber, number, multiplicationNumber * number);
                multiplicationNumber++;
            }
            Console.ReadLine();
        }
    }
}
