using System;
using System.Collections.Generic;
using System.Linq;

namespace SumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] r = { 54, 23, 66, 12 };
            List<int> rList = new List<int>();
            rList = r.ToList();
            Console.WriteLine(rList[1] + rList[2]);
            Console.ReadLine();
        }
    }
}
