using System;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add your word!");
            File.WriteAllText(@"user/documents/greenfox/suchtext.txt", true, Console.ReadLine());

            Console.WriteLine("Please add your number!");
            Console.WriteLine(Console.);

        }
    }
}
