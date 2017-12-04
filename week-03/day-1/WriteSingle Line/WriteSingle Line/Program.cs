using System;
using System.IO;

namespace WriteSingle_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                File.WriteAllText("my-file.txt", "Nóra Fraknóy");
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
            finally
            {
                Console.WriteLine();
                Console.ReadLine();
            }
            
        }
    }
}
