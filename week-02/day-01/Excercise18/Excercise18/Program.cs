using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number % 2 != 0)
            {
                Console.WriteLine("Your number is Odd");
            }
            else
            {
                Console.WriteLine("Your number is Even");
            }

        }    
    }
}
