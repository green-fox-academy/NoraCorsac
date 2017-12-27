using System;

namespace CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);

            Console.WriteLine("Please enter a second number: ");
            string input2 = Console.ReadLine();
            int number2 = int.Parse(input2);

            if (number1 >= number2)
            {
                Console.WriteLine("The second number should be bigger!");
            }
            else
            {
                for (int i = 0; i < (number2 - number1); i++)
                {
                    Console.WriteLine(i + number1);
                }
            }
            Console.ReadLine();
        }
    }
}
