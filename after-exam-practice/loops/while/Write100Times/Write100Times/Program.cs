using System;

namespace Write100Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            while (a < 100)
            {
                Console.WriteLine("{0}. I won't cheat on the exam!", a);
                a++;
            }
            Console.ReadLine();
        }
    }
}
