using System;

namespace SumAllElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ai = { 3, 4, 5, 6, 7 };
            int sum = 0;

            for (int i = 0; i < ai.Length; i++)
            {
                sum = sum + ai[i];
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
