using System;
using System.Text;

namespace TakesLonger
{
    class Program
    {
        public static void Main(string[] args)
        {
            StringBuilder quote = new StringBuilder("Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.");

            quote.Insert(21, "always takes longer than ");

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            Console.WriteLine(quote);
            Console.ReadLine();
        }
    }
}
