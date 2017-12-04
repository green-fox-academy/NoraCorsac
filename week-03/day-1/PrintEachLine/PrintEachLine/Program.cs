using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                File.ReadAllText(@"my-file.txt");
                Console.WriteLine(File.ReadAllText(@"my-file.txt"));
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Uh-oh, could not read the file!");
            }

            Console.ReadLine();
        }
    }
}