using System;
using System.IO;
using System.Text;

namespace CopyFile
{
    class Program
    {
        // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
        // It should take the filenames as parameters
        // It should return a boolean that shows if the copy was successful
        static void Main(string[] args)
        {
            string fileToRead = @"C:\Users\Zoli\greenfox\NoraCorsac\week-03\day-1\CopyFile\CopyFile\file-to-read";
            string fileToWrite = @"C:\Users\Zoli\greenfox\NoraCorsac\week-03\day-1\CopyFile\CopyFile\file-to-write";
            CopyFile(fileToRead, fileToWrite);
            Console.ReadLine();
        }
        static bool CopyFile(string readFile, string writeFile)
        {
            try
            {
                string[] array = File.ReadAllLines(readFile);
                File.WriteAllLines(writeFile, array);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
