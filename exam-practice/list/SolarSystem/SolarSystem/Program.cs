using System;
using System.Collections.Generic;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };

            planetList.Insert(5, "Saturn");
            for (int i = 0; i < planetList.Count; i++)
            {
                Console.WriteLine(planetList[i]);
            }
            Console.ReadLine();
        }
    }
}
