using System;

namespace SwapElement
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] abc = { "first", "second", "third" };

            //Console.WriteLine(abc[2] + "\n" +  abc[1] + "\n" + abc[0]);

            string temp = abc[0];
            abc[0] = abc[2];
            abc[2] = temp;

            Console.WriteLine(abc[0] + "\n" + abc[1] + "\n" + abc[2]);

            /*for (int i = 2; i < abc.Length; i--)
            {
                Console.WriteLine(abc[i]);
            }*/

            Console.ReadLine();
        }
    }
}
