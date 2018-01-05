using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";
            greet(al);
            Console.ReadLine();
        }
        public static void greet(string name)
        {
            Console.WriteLine("Hello dear, " + name + "!");
        }
    }
}
