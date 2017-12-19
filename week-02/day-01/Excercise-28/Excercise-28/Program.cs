using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add the number of triangle's lines: ");
            string input = Console.ReadLine();
            int lines = int.Parse(input);

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
                
            Console.ReadLine();
        }
    }
}
