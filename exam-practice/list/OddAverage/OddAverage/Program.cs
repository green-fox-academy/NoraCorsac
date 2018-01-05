using System;
using System.Collections.Generic;

namespace MutualElements
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a method that takes two integer lists as a parameter
            // and returns an integer list with the mutual elements from the lists.
            // Write at least 3 different test cases.

            // For example:
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            var mutualElements = OddsAverage(numbers);

            mutualElements.ForEach(i => Console.Write("{0}, ", i));
            // Should print: 
            // [3,4]

            Console.ReadLine();
        }

        public static List<int> OddsAverage(List<int> numbers)
        {
            List<int> odds = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    odds.Add(number);
                }
            }
            
            return odds;
        }
    }
}