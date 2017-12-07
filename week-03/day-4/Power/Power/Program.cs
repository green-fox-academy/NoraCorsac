using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = 5;
            int exponent = 3;
            Console.WriteLine(Power(baseNumber, exponent));
            Console.ReadLine();
        }
        static int Power(int baseNumber, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            else
            {
                return baseNumber * Power(baseNumber, exponent - 1);
            }

        }
    }
}
