using System;

namespace ChangeElement
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `s`
            int[] s = { 1, 2, 3, 8, 5, 6 };
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            s[3] = 4;
            // - Change the 8 to 4
            // - Print the fourth element
            Console.WriteLine(s[3]);
            Console.ReadLine();
        }
    }
}
