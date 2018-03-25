using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WorstSong
{
    class Program
    {
        static void Main(string[] args)
        {
            BadSongs(@"100worst.csv");
        }
        static void BadSongs(string filename)
        {
            string[] songs = { };
            songs = File.ReadAllLines(filename, Encoding.Default);
            List<int> songList = new List<int>();
            songList = songList.ToList();
        }
        
        static int[] WorstSongs(int[] inputArray)
        {
            int[] result = new int[30];
            for (int i = 0; i < 30; i++)
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
