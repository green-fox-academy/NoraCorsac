using System;

namespace HelloUserFromInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What's your name? Please enter: ");
            Console.WriteLine("Hello, {0}! Have a nice day!", Console.ReadLine());
            Console.ReadLine();
        }
    }
}
