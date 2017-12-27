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

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", i, number, i * number);
            }
            Console.ReadLine();
        }
    }
}
