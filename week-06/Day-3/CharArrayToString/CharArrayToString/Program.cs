using System;

namespace CharArrayToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] myArray = { 'a', 's', 'B', 'E', 'S', 'T' };

            string arrayToString = string.Join(string.Empty, myArray);
            Console.WriteLine(arrayToString);
            Console.ReadLine();
        }
    }
}
