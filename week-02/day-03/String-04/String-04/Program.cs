using System;

namespace TodoPrint
{
    public class TodoPrint
    {
        public static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";

            Console.WriteLine("My todo:\n" + todoText + " - Download games\n" + ("     - Diablo"));
            Console.ReadLine();

           
        }
    }
}