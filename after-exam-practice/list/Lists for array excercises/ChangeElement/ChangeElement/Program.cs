using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 2, 3, 8, 5, 6 };
            List<int> sList = new List<int>();
            sList = s.ToList();
            sList[3] = 4;

            Console.WriteLine(sList [3]);
            Console.ReadLine();
        }
    }
}
