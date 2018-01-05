using System;
using System.Text;

namespace ToDoPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";

            //Console.WriteLine("My todo:\n" + todoText + " - Download games\n" + ("     - Diablo"));
            
            /*todoText = todoText.Insert(0, "My todo:\n");
            todoText = todoText.Insert(todoText.LastIndexOf("\n"), "\n - Download games");
            todoText = todoText.Insert(todoText.LastIndexOf("\n"), "\n   - Diablo");
            Console.WriteLine(todoText);*/

            var builder = new StringBuilder();
            builder = builder.Append(todoText);
            builder = builder.Insert(0, "My todo:\n");
            builder = builder.Append(" - Download games");
            builder = builder.Append("\n   - Diablo");

            Console.WriteLine(builder.ToString());
            Console.ReadLine();
        }
    }
}
