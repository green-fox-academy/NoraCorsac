using System;
using System.Linq;

namespace CharacterFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "kfkjdfkjguoiug njdnjfhtforlgknjsh";

            var frequencyOfChars = myString.Select(c => c)
                .GroupBy(c => c)
                .ToDictionary(n => n.Key, n => n.Count());

            foreach (var pair in frequencyOfChars)
            {
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }
            Console.ReadLine();
        }
    }
}
