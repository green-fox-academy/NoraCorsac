using System;
using System.Linq;

namespace SquaredValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var squaredPositiveNumbers = from i in n
                                         where i > 0
                                         select i;
            foreach (var number in squaredPositiveNumbers)
            {
                Console.WriteLine(number * number);
            }
            Console.ReadLine();
        }
    }
}
