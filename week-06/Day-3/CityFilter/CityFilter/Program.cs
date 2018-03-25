using System;
using System.Linq;

namespace CityFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var filteredCities = cities.Where(n => n[0] == 'A' && n.Last() == 'I');

            foreach (var city in filteredCities)
            {
                Console.WriteLine(city);
            }
            Console.ReadLine();
        }
    }
}
