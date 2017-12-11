using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Dice
    {
        public int D6 { get; set; }

        public static Random random = new Random();

        public void Roll()
        { 
            D6 = random.Next(1, 7);
        }
    }
}
