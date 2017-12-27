using System;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            int ak = 123;
            Console.WriteLine(doubling(ak));
            Console.ReadLine();
        }
        public static int doubling(int number1)
        {
            return (number1 * 2);
        }
    }
}
