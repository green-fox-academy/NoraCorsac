using System;

namespace Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] colors =
            {
                { "lime", "forest green", "olive", "pale green", "spring green" },
                { "orange red", "red", "tomato", "", "" },
                { "orchid", "violet", "pink", "hot pink", "" }
            };

            Console.WriteLine(colors[2, 1]);

            Console.ReadLine();
        }
    }
}
