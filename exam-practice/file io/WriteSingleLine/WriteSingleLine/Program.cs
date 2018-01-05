using System;
using System.IO;
using System.Text;

namespace WriteSingleLine
{
    class Program
    {
        // Open a file called "my-file.txt"
        // Write your name in it as a single line
        // If the program is unable to write the file,
        // then it should print an error message like: "Unable to write file: my-file.txt"
        static void Main(string[] args)
        {
            try
            {
                string name = "Nóra Fraknóy";
                File.WriteAllText("my-file.txt", name);
            }
            catch
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
