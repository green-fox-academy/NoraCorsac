using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter(15);
            Console.ReadLine();
            
        }
        static int Counter (int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(n);
                return Counter(n - 1);
            }

        }
    }
}
