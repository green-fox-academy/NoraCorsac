using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;

            int a2 = b;
            int b2 = a;

            Console.WriteLine(" A = {0},\n B = {1}.", b, a);
            Console.ReadLine();
        }
    }
}