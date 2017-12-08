using System;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(String1(input));
            Console.ReadLine();
        }
        static string String1(string input)
        {
            if (input.IndexOf("x") == -1)
            {
                return input;
            }
            else
            {
                int index = input.IndexOf("x");
                input = input.Remove(index, 1);
                input = input.Insert(index, "y");
                return String1(input);
            }

        }

    }
}
