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

        public void Roll()
        {
            Random random = new Random();
            D6 = random.Next(1, 7);
        }
    }
}
