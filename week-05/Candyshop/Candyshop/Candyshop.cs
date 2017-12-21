using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyshop
{
    class Candyshop
    {
        List<Sweets> CandyStorage = new List<Sweets>();

        public double TotalSugar { get; set; }
        public double Income { get; set; }
        private int lollipopCounter = 0;
        private int candyCounter = 0;
        
        public Candyshop(int sugarInGramm)
        {
            TotalSugar = sugarInGramm;
        }
        public void Raise(int percentage)
        {
            foreach (Sweets sweet in CandyStorage)
            {
                sweet.Price = sweet.Price * (1.0 * percentage / 100.0);
            }
        }
        public void Createsweets(string typeOfSweet)
        {
            if (typeOfSweet == "lollipop")
            {
                CandyStorage.Add(new Lollipop());
                TotalSugar -= 5;
                lollipopCounter++;
            }
            else if (typeOfSweet == "candy")
            {
                CandyStorage.Add(new Candy());
                TotalSugar -= 10;
                candyCounter++;
            }
        }
        public void Sell(string typeOfSweet)
        {
            for (int i = 0; i < Sweets.count; i++)
            {
                if (typeOfSweet == "lollipop")
                {
                    lollipopCounter--;
                    Income += 10;
                }
                else if (typeOfSweet == "candy")
                {
                    candyCounter--;
                    Income += 20;
                }
            }
        }
        public void BuySugar(int buySugar)
        {
            int PriceOfSugar = buySugar / 10;
            TotalSugar += buySugar;
            Income -= PriceOfSugar;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Invetory: {0} candies, {1} lollipops, Income: {2}$, Sugar: {3}gr", CandyCounter, LollipopCounter, Income, sugar);
        }
    }
}
