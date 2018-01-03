using System;
using System.Linq;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            double average = n.Average();
            Console.WriteLine(average);
            Console.ReadLine();
        }
    }
}
