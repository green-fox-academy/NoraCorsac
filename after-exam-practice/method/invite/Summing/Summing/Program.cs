using System;

namespace Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add your number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            Console.WriteLine(Sum(number));
            Console.ReadLine();

        }
        public static int Sum(int number)
        {
            return (number * (number + 1) / 2);
        }
    }
}
