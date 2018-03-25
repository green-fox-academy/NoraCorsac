using System;
using System.Collections.Generic;
using System.IO;

namespace WorstSongs
{
    // The 100worst.csv file contains the 100 worst singles over 25 years.
    // Your task is to check which year produced the most.
    // So create the necessary method(s).
    // And print out the sentence below with the proper year.
    //  `The year when the most worst songs came out is <year>.`
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The year when the most worst songs came out is {year}.");

            
        }
        public static void Reader()
        {
            try
            {
                string[] songs = File.ReadAllLines(@"./100worst.csv");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void Splitter(string songs)
        {
            string[] lines = songs.Split(";");

            var years = new Dictionary<string, int>();

            foreach (var line in lines) 
            {
                if (years.ContainsKey(line.)
                {
                    ++;
                }
                else
                {
                    years.Add(line, 1);
                }
            }

            int worstYear = 0;

            foreach (var year in years)
            {
                if (year.Value == )
                {
                    worstYear = Int32.Parse(year.Key);
                }
            }
        }
    }
}
