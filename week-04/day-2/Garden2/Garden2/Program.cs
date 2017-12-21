using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden2
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden();

            Flowers flower0 = new Flowers("yellow");
            garden.AddPlant(flower0);
            Flowers flower1 = new Flowers("blue");
            garden.AddPlant(flower1);

            Tree tree0 = new Tree("purple");
            garden.AddPlant(tree0);
            Tree tree1 = new Tree("orange");
            garden.AddPlant(tree1);

            garden.CheckStatus();

            garden.Watering(40);
            garden.CheckStatus();

            garden.Watering(70);
            garden.CheckStatus();

            Console.ReadLine();
        }
    }
}
