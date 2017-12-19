using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add the lines of the pyramid: ");
            string input = Console.ReadLine();
            int lines = int.Parse(input);

            for (int i = 0; i <= lines; i++)
            {
                for (int j = 0; j < lines - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 + 1; j++)
                {
                    Console.WriteLine("*");
                }
            }
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}
