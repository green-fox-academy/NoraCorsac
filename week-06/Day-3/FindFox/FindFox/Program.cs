using System;
using System.Collections.Generic;
using System.Linq;

namespace FindFox
{
    class Program
    {
        static void Main(string[] args)
        {
            var foxList = new List<Fox>();

            foxList.Add(new Fox("Liza", "red", "corsac"));
            foxList.Add(new Fox("Sanyi", "green", "pallida"));
            foxList.Add(new Fox("Béla", "yellow", "pallida"));
            foxList.Add(new Fox("Karcsi", "green", "corsac"));
            foxList.Add(new Fox("Juci", "green", "pallida"));

            var greenFoxes = foxList.Where(f => f.Color == "green");
            var pallidaFoxes = foxList.Where(f => f.Type == "pallida");

            var pallidaGreenFoxes = foxList.Where(f => f.Color == "green" && f.Type == "pallida");

            Console.WriteLine("The GreenFoxes from Pallida are: ");

            foreach (Fox fox in pallidaGreenFoxes)
            {
                Console.WriteLine(fox.Name);
            }
            Console.ReadLine();
        }
    }
}
