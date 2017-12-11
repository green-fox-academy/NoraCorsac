using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dice;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Dice> dices = new List<Dice>();

            for (int i = 0; i < 6; i++)
            {
                dices.Add(new Dice());
            }

            for (int j = 0; j < dices.Count; j++)
            {
                dices[j].Roll();  
            }
            Console.WriteLine();

            for (int j = 0; j < dices.Count; j++)
            {
                Console.WriteLine(dices[j].GetCurrent() + " ");
            }
            
            Console.ReadLine();
        }
    }
}
