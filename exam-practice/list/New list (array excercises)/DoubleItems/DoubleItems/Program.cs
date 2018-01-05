using System;
using System.Collections.Generic;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ag = new List<int> { 3, 4, 5, 6, 7 };
            foreach (int number in ag)
            {
                Console.WriteLine(number + " " + number);
            }
            Console.ReadLine();
        }
    }
}
