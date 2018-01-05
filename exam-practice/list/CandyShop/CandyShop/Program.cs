using System;
using System.Collections.Generic;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list. 
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines

            /*list.RemoveAt(1);
            list.Insert(1, "Croissant");
            list.Remove(false);
            list.Add("Ice cream");*/

            list[1] = "Croissant";

            list[3] = "Ice cream";

            foreach (string sweets in list)
            {
                Console.WriteLine(sweets);
            }
            
            Console.ReadLine();

        }
    }
}
