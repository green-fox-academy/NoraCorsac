using System;

namespace Bunny2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ears(120));
            Console.ReadLine();

        }
        static int Ears(int bunny)
        {
            if (bunny == 0)
            {
                return 0;
            }
            else if (bunny % 2 == 0)
            {
                return 2 + Ears(bunny - 1);
            }
            else
            {
                return 3 + Ears(bunny - 1);
            }
        }
    }
}
