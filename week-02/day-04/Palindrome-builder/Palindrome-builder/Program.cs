using System;
using System.Text;

namespace PalindromeBuilder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to reverse :");
            string word = Console.ReadLine();

            StringBuilder builder = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                builder.Append(word[i]);
            }
            string newName = builder.ToString();

            Console.WriteLine(word + " => " + newName);
            Console.ReadLine();
        }
    }
}