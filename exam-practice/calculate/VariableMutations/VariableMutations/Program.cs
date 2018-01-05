using System;

namespace VariableMutations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            // make it bigger by 10

            Console.WriteLine(a + 10);

            int b = 100;
            // make it smaller by 7

            Console.WriteLine(b - 7);

            int c = 44;
            // please double c's value

            Console.WriteLine(c * 2);

            int d = 125;
            // please divide by 5 d's value

            Console.WriteLine(d / 5);

            int e = 8;
            // please cube of e's value

            Console.WriteLine(e * e);

            int f1 = 123;
            int f2 = 345;
            bool bigger = f1 > f2;
            Console.WriteLine("It is " + bigger + " that " + f1 + " is bigger than " + f2 + ".");
            // tell if f1 is bigger than f2 (print as a boolean)

            int g1 = 350;
            int g2 = 200;

            if (g2 * 2 > g1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // tell if the double of g2 is bigger than g1 (print as a boolean)

            int h = 1357988018575474;
            double divisor = h % 11;
            if (divisor == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            // tell if it has 11 as a divisor (print as a boolean)

            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)

            int j = 1521;
            // tell if j is dividable by 3 or 5 (print as a boolean)

            string k = "Apple";
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(k);
            }
            //fill the k variable with its cotnent 4 times
        }
    }
}
