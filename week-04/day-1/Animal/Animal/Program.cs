using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            var Animal = new Animal();

            Console.WriteLine("Current hunger level: {0}", Animal.Hunger);
            Console.WriteLine("Current thirst level: {0}", Animal.Thirst);
            Animal.Eat();
            Console.WriteLine("Let's eat! The current hunger level is: {0}", Animal.Hunger);
            Animal.Drink();
            Console.WriteLine("Let's drink! The current thirst level is: {0}", Animal.Thirst);
            Animal.Play();
            Console.WriteLine("Let's play! The current hunger and thirst level is: {0} , {0}", Animal.Hunger, Animal.Thirst);
            Console.ReadLine();
        }
    }
}
