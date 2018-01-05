using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        // then returns the number of lines the file contains.
        // It should return zero if it can't open the file, and
        // should not raise any error.
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please add the file's path: ");
                string userFile = Console.ReadLine();
                LineCounter(userFile);
            }
            catch
            {
                Console.WriteLine("0");
            }
            finally
            {
                Console.ReadLine();
            }
        }
        static int LineCounter(string filename)
        {
            string[] filesLines = File.ReadAllLines(filename);
            int countLines = filesLines.Length;
            return countLines;
        }
    }
}
