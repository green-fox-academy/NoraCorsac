using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22;
            int b = 13;
            double c;

            c = a + b;
            Console.WriteLine("22+13={0}", c);

            c = a - b;
            Console.WriteLine("22-13={0}", c);

            c = a * b;
            Console.WriteLine("22*13={0}", c);

            c = 22.0 / 13.0;
            Console.WriteLine("22/13={0}", c);

            c = a / b;
            Console.WriteLine("22/13={0}", c);

            c = a % b;
            Console.WriteLine("22/13's reminder={0}", c);

            Console.ReadLine();
            
        }
    }
}