using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
             string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            char[] inputreversed = reversed.ToCharArray();
            Array.Reverse(inputreversed);
            string reversed2 = new string(inputreversed);

            Console.WriteLine(reversed2);
            Console.ReadLine();
        }
    }
}
