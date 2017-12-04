using System;
using System.Text;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberOfLines("Suchtext.txt");
        }
        static void NumberOfLines(string filename)
        {
            string[] array = { };

            try
            {
                array = File.ReadAllLines(filename, Encoding.Default);
            }
            catch
            {
                Console.WriteLine("Zero");
            }
            finally
            {
                foreach (var file in array)
                {
                    Console.WriteLine(file);
                }

                int lines = array.Length;

                Console.WriteLine(lines);
                Console.ReadLine();
            }


        }
    }
}
