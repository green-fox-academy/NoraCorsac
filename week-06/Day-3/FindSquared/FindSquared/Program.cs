using System;
using System.Linq;

namespace FindSquared
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };
            var nums = from i in n
                       where i * i > 20
                       select i;

            foreach (var numbers in nums)
            {
                Console.WriteLine(numbers);
            }
            Console.ReadLine();
        }
    }
}
