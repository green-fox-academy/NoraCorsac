using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            var gardenList = new List<Garden>();
            var tree = new Tree();
            var flower = new Flower();
            gardenList.Add(tree);
            gardenList.Add(flower);
        }
    }
}
