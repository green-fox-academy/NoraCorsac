using System;

namespace Bunny1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ears(4));
            Console.ReadLine();
            
        }
        static int Ears(int bunny)
        {
            if (bunny == 1)
            {
                return 2;
            }
            else
            {
                return 2 + Ears(bunny - 1);
            }
        }
    }
}
