using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "Kuty";
            appendA(am);
        }
        public static void appendA(string word)
        {
            Console.WriteLine(word + "a");
            Console.ReadLine();
        }
    }
}
