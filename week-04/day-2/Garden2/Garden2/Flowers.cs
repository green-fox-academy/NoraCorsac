using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden2
{
    class Flowers : Plant
    {
        public Flowers(string color)
        {
            Color = color;
            Type = "Flower";
            Water = 0;
            Absorbation = 0.75;
            WaterNeed = 5;
            Thirsty = (WaterNeed > Water);
        }
    }
}
