using System;

namespace DefineInfos
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nóri Fraknóy";
            int age = 27;
            double height = 1.70;
            bool marriage = true;
            Console.WriteLine("Hello! My name is {0}, I'm {1} years old and {2} meters high. Am I married? {3}!", name, age, height, marriage);
            Console.ReadLine();
        }
    }
}
