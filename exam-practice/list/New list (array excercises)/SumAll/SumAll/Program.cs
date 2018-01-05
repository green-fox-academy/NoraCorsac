using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ai = new List<int> { 3, 4, 5, 6, 7 };

            int sum = ai.Sum();

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
