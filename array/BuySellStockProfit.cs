using System;

namespace ADS.array
{

	/// <summary>
	/// Date 03/04/2016
	/// @author Tushar Roy
	/// 
	/// Best time to buy and sell stocks.
	/// 1) Only 1 transaction is allowed
	/// 2) Infinite number transactions are allowed
	/// 
	/// Time complexity O(n)
	/// Space complexity O(1)
	/// 
	/// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
	/// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
	/// </summary>
	public class BuySellStockProfit
	{

		public virtual int oneProfit(int[] arr)
		{
			int minPrice = arr[0];
			int maxProfit = 0;
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] - minPrice > maxProfit)
				{
					maxProfit = arr[i] - minPrice;
				}
				if (arr[i] < minPrice)
				{
					minPrice = arr[i];
				}
			}
			return maxProfit;
		}

		public virtual int allTimeProfit(int[] arr)
		{
			if (arr.Length == 0)
			{
				return 0;
			}
			int profit = 0;
			int localMin = arr[0];
			for (int i = 1; i < arr.Length;i++)
			{
				if (arr[i - 1] >= arr[i])
				{
					localMin = arr[i];
				}
				else
				{
					profit += arr[i] - localMin;
					localMin = arr[i];
				}

			}
			return profit;
		}

		public static void Main(string[] args)
		{
			int[] arr = new int[] {7,10,15,5,11,2,7,9,3};
			int[] arr1 = new int[] {6,4,1,3,5,7,3,1,3,4,7,9,2,5,6,0,1,2};
			BuySellStockProfit bss = new BuySellStockProfit();
			Console.WriteLine(bss.oneProfit(arr));
			Console.Write(bss.allTimeProfit(arr1));

		}
	}

}