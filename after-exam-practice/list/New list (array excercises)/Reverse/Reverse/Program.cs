using System;
using System.Collections.Generic;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> aj = new List<int> { 3, 4, 5, 6, 7 };
            aj.Reverse();
            foreach (int number in aj)
            {
            Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
