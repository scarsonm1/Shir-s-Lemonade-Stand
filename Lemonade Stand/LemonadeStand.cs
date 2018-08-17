using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand
{
    class LemonadeStand
    {
        public string Name { get; set; }
        public int NumberOfCups { get; set; }
        public int PricePerCup { get; set; }
        public int CostPerCup { get; set; }

        public int TotalRevenue()
        {
            return NumberOfCups * PricePerCup;
        }

        public int TotalExpenses()
        {
            return NumberOfCups * PricePerCup;
        }

        public int TotalProfit()
        {
            return TotalRevenue() - TotalExpenses();
        }
    }
}
