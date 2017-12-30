using System;
using System.Collections.Generic;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> abc = new List<string> { "first", "second", "third" };
            abc[2] = abc[0];
            abc[0] = "third";
            foreach (string element in abc)
            {
            Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
