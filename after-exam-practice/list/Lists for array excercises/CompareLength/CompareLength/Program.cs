using System;
using System.Collections.Generic;
using System.Linq;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 4, 5 };
            List<int> p1List = new List<int>(p1);
            List<int> p2List = new List<int>(p2);
            p1List = p1.ToList();
            p2List = p2.ToList();

            if (p2List.Count > p1List.Count)
            {
                Console.WriteLine("p2 has more elements than p1");
            }
            else
            {
                Console.WriteLine("Ooops");
            }
            Console.ReadLine();
        }
    }
}
