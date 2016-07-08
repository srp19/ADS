using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.array
{
    public class BuyAndSellStocks
    {
        private int MaxProfit(int[] stockPrices)
        {
            /*
            minPrice=100
            maxProfit=0

            ===it-1
            minPrice-80
            maxProfit-0

            ===it-2
            minPrice-80
            maxProfit-40 (120-80 > 0)

            ===it-3
            minPrice=80
            maxProfit=50

            ..
            */

            int minPrice = stockPrices[0];
            int maxProfit = 0;

            for (int i = 1; i < stockPrices.Length; i++)
            {
                if (stockPrices[i] - minPrice > maxProfit)
                {
                    maxProfit = stockPrices[i] - minPrice;
                }
                if (stockPrices[i] < minPrice)
                {
                    minPrice = stockPrices[i];
                }

            }
            return maxProfit;
        }

        private int AlltimeProfitNonOverlapping(int[] stockPrices)
        {
            int maxProfit = 0;

            for (int i = 1; i < stockPrices.Length; i++)
            {
                if (stockPrices[i] - stockPrices[i-1] > 0)
                {
                    maxProfit += (stockPrices[i] - stockPrices[i - 1]);
                }

            }
            return maxProfit;
        }
        public void Main()
        {
            int[] stockPrices = { 100, 80, 120, 130, 70, 60, 100, 125 };
            Console.WriteLine("Max Profit = " + MaxProfit(stockPrices));
            Console.WriteLine("Alltime Profit = " + AlltimeProfitNonOverlapping(stockPrices));
        }
    }
}
