﻿using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 526;
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}
