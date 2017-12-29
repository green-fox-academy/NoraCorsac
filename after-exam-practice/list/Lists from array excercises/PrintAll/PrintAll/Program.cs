using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] af = { 4, 5, 6, 7 };
            List<int> afList = new List<int>();
            afList = af.ToList();

            for (int i = 0; i < afList.Count; i++)
            {
                Console.WriteLine(afList[i]);
            }
            Console.ReadLine();
        }
    }
}
