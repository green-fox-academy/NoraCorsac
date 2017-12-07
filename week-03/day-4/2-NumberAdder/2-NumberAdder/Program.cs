using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Counter(5)); 
            Console.ReadLine();

        }
        static int Counter(int number)
        {
            if (number ==1)
            {
                return 1;
            }
            else
            {
                return number + Counter(number - 1);
            }
        }
    }
}
