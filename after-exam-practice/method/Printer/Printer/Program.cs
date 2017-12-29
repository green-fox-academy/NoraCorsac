using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer("first", "second", "third", "fourth");
            Console.ReadLine();
        }
        public static void Printer(params string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }
    }
}
