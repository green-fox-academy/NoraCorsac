using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "I won't cheat on the exam!";

            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"
             for (int i = 0; i < 100; i++)
             {
                 Console.WriteLine(a);
             }
                 Console.ReadLine();
        }
    }
}
