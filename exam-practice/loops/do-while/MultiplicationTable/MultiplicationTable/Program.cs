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
            int multiplicandNumber = 1;

            do
            {
                Console.WriteLine("{0} * {1} = {2}", multiplicandNumber, number, multiplicandNumber * number);
                multiplicandNumber++;
            } while (multiplicandNumber <= 10);

            Console.ReadLine();
        }
    }
}
