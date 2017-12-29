using System;
using System.Collections.Generic;
using System.Linq;

namespace IncrementElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = { 1, 2, 3, 4, 5 };
            List<int> tList = new List<int>();
            tList = t.ToList();
            Console.WriteLine(tList[2] + 2);
            Console.ReadLine();
        }
    }
}
