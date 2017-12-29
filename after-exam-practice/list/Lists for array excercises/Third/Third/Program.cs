using System;
using System.Collections.Generic;
using System.Linq;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] q = { 4, 5, 6, 7 };
            List<int> qList = new List<int>();
            qList = q.ToList();

            Console.WriteLine(qList[2]);
            Console.ReadLine();
        }
    }
}
