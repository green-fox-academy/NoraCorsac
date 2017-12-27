using System;

namespace PrintEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -2;

            while (a < 500)
            {
            Console.WriteLine(a += 2);
            }
            Console.ReadLine();
        }
    }
}
