using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumdigit
{
    class Program
    {
        // Given a non-negative int n, return the sum of its digits recursively (no loops). 
        // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
        // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).
        static void Main(string[] args)
        {
            Console.WriteLine(Sumdigit(67891135));
            Console.ReadLine();
        }
        static int Sumdigit(int number)
        {
            if (number < 10)
            {
                return number;
            }
            else
            {
                return (number % 10) + Sumdigit(number / 10);
            }
        }
    }
}
