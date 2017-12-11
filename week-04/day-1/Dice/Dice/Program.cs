using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dice> dices = new List<Dice>();

            for (int i = 0; i < 100; i++)
            {
                dices.Add(new Dice() { D6 = 6 });
            }

            for (int j = 0; j < dices.Count; j++)
            {
                dices[j].Roll();  
            }
        }
    }
}
