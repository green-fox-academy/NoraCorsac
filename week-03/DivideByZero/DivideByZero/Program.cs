using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number: ");

            try
            {
                int divisor = int.Parse(Console.ReadLine());
                int result = 10 / divisor;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("fail");
            }
            catch (Exception e)
            {
                Console.WriteLine();
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
