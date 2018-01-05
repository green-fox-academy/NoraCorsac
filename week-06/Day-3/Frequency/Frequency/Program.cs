using System;
using System.Linq;

namespace Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var freqencyOfNumbers = n.Select(x => x)
                                    .OrderByDescending(x => x)
                                    .GroupBy(k => k)
                                    .ToDictionary(x => x.Key, x => x.Count());

            foreach (var number in freqencyOfNumbers)
            {
                Console.WriteLine($"{number}");
            }
            Console.ReadLine();
        }
    }
}
