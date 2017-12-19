using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first number: ");
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);

            Console.WriteLine("Please enter your second number: ");
            string input2 = Console.ReadLine();
            int number2 = int.Parse(input2);

            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else if (number1 == number2)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine(number2);
            }
            Console.ReadLine();
        }
    }
}
