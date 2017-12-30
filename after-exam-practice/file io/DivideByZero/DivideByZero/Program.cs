using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in the divisor number: ");

            try
            {
                double divisorNumber = double.Parse(Console.ReadLine());
                double result = 10 / divisorNumber;
                Console.WriteLine("10 / " + divisorNumber + " = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("fail");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
