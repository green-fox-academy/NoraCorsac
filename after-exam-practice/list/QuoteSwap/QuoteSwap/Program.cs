using System;
using System.Collections.Generic;

namespace QuoteSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };
            list[2] = "cannot";
            list[5] = "do";

            foreach (string quote in list)
            {
                Console.Write(quote + " ");
            }
            Console.ReadLine();
        }
    }
}
