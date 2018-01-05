using System;
using System.IO;
using System.Text;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes 3 parameters: a path, a word and a number,
            // than it should write to a file.
            // The path parameter should be a string, that describes the location of the file.
            // The word parameter should be a string, that will be written to the file as lines
            // The number paramter should describe how many lines the file should have.
            // So if the word is "apple" and the number is 5, than it should write 5 lines
            // to the file and each line should be "apple"
            // The function should not raise any error if it could not write the file.
            

        }
        public static void FileWriter(string path, string word, int number)
        {
            path = @"C:\Users\Zoli\greenfox\NoraCorsac\exam-practice\file io\WriteMultipleLines\WriteMultipleLines";

            StreamWriter myWriter = new StreamWriter(path);

            try
            {
                for (int i = 0; i < number - 1; i++)
                {
                    myWriter.WriteLine(word);
                }
                myWriter.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }


        }
    }
}
