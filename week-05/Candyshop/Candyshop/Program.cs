using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyshop
{
    class Program
    {
        public static void Main(string[] args)
        {
            Candyshop candyshop = new Candyshop(300);
            Candyshop.Createsweets("candy");
            Candyshop.CreateSweets("lollipop");
            Candyshop.PrintInfo();
            // Should print out:
            // Invetory: 2 candies, 2 lollipops, Income: 0$, Sugar: 270gr
            CandyShop.Sell(CandyShop.CANDY, 1);
            candyShop.PrintInfo();
            // Should print out:
            // "Invetory: 1 candies, 2 lollipops, Income: 20$, Sugar: 270gr"
            CandyShop.Raise(5);
            CandyShop.Sell(CandyShop.LOLLIPOP, 1);
            candyShop.PrintInfo();
            // Should print out:
            // "Invetory: 1 candies, 1 lollipops, Income: 30.5$, Sugar: 270gr"
            candyShop.BuySugar(300);
            candyShop.PrintInfo();
        }
    }
}
