using System;

namespace PrintEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -2;
            do
            {
                if (a % 2 == 0)
                {
                Console.WriteLine(a += 2);
                }
            }
            while (a < 500);
            Console.ReadLine();
        }
    }
}
