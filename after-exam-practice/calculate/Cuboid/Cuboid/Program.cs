using System;

namespace Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            double sides = 10;
            double powerSurfaceArea = 2;
            double powerVolume = 3;
            double cuboidSides = 6;

            double surfaceArea = (Math.Pow(sides, powerSurfaceArea)) * cuboidSides;
            double volume = Math.Pow(sides, powerVolume);

            Console.WriteLine("Surface Area: {0}\nVolume: {1}", surfaceArea, volume);
            Console.ReadLine();
        }
    }
}
