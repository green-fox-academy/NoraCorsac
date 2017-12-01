using System;

namespace GreenFox
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

            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000
        }
    }
}