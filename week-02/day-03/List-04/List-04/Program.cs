using System;
using System.Collections.Generic;

namespace CandyShop
{
    public class Candyshop
    {
        public static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            list.Clear();
            list.Add("Cupcake");
            list.Add("Croissant");
            list.Add("Brownie");
            list.Add("Ice cream");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            // Accidentally we added "2" and "false" to the list. 
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines

            

            
            Console.ReadLine();
        }
    }
}