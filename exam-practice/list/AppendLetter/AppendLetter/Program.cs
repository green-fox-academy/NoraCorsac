using System;
using System.Collections.Generic;
using System.Text;

namespace AppendLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Add "a" to every string in the far list.
            /*for (int i = 0; i < far.Count; i++)
            {
                far[i] += "a";
                Console.WriteLine(far[i]);
            }*/

            foreach (string animals in far)
            {
                var fixedAnimals = new StringBuilder();
                fixedAnimals.Append(animals);
                fixedAnimals.Append("a");
                Console.WriteLine(fixedAnimals);
            }

            Console.ReadLine();
        }
    }
}
