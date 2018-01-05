using System;
using System.IO;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"100worst.csv";
            int[] thefinalArray = FindWorstSong(WriteSongsDataIntoArray(source));
            foreach (int year in thefinalArray)
            {
                Console.WriteLine(year);
            }
            Console.ReadLine();
        }

        static int[] WriteSongsDataIntoArray(string source)
        {
            var sr = new StreamReader(source);
            string line = "";
            int[] options = new int[150];

            try
            {
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] splitData = line.Split(';');
                        for (int i = 11; i < line.Length; i++)
                        {
                            options[(int.Parse(splitData[i])) - 1] += 1;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
            }
            return options;
        }
        static int[] FindWorstSong(int[] inputArray)
        {
            int[] result = new int[20];
            for (int i = 0; i < 20; i++)
            {
                int currentMaxIndex = 0;
                for (int j = 1; j < inputArray.Length; j++)
                {
                    if (inputArray[currentMaxIndex] < inputArray[j])
                    {
                        currentMaxIndex = j;
                    }
                }
                result[i] = currentMaxIndex + 1;
                inputArray[currentMaxIndex] = -1;
            }
            return result;
        }
    }
}