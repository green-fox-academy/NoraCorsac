using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Garden
    {
        public string Color { get; set; }
        public int Water { get; set; } = 0;
        public double AbsorbCapacity { get; set; }

        List<Flower> flowers = new List<Flower>();
        List<Tree> trees = new List<Tree>();

        public Garden(string color, int water, double absorbcapacity)
        {
            Color = color;
            Water = water;
            AbsorbCapacity = absorbcapacity;
        }

        public void PlantList(Plant plant)
        {
            List<Plant> PlantList = new List<Plant>();

        }
    }
}
