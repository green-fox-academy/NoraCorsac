using System;
using System.Linq;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var evenNumbers = from i in n
                              where i % 2 == 0
                              select i;
            foreach (var numbers in evenNumbers)
            {
                Console.WriteLine(numbers);
            }
            Console.ReadLine();
        }
    }
}
