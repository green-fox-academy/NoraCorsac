using System;
using System.Collections.Generic;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nimals = new List<string> { "kuty", "macsk", "cic" };
            foreach (string animal in nimals)
            {
                Console.WriteLine(animal + "a");
            }
            Console.ReadLine();
        }
    }
}
