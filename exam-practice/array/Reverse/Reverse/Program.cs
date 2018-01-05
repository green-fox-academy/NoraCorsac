using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aj = { 3, 4, 5, 6, 7 };
            Array.Reverse(aj);

            foreach (int element in aj)
            {
                Console.WriteLine(element);
            }

            /*for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(aj[i]);
            }*/
            Console.ReadLine();
        }
    }
}
