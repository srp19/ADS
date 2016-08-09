using System;

namespace ADS.array
{

	/// <summary>
	/// Date 04/`7/2016
	/// @author Tushar Roy
	/// 
	/// Find the contiguous subarray within an array (containing at least one number) which has the largest product.
	/// 
	/// Time complexity is O(n)
	/// Space complexity is O(1)
	/// 
	/// http://www.geeksforgeeks.org/maximum-product-subarray/
	/// https://leetcode.com/problems/maximum-product-subarray/
	/// </summary>
	public class MaxProductSubarray
	{

		public virtual int maxProduct(int[] nums)
		{
			int min = 1;
			int max = 1;
			int maxSoFar = nums[0];
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] > 0)
				{
					max = max * nums[i];
					min = Math.Min(min * nums[i], 1);
					maxSoFar = Math.Max(maxSoFar, max);
				}
				else if (nums[i] == 0)
				{
					min = 1;
					max = 1;
					maxSoFar = Math.Max(maxSoFar, 0);
				}
				else
				{
					int t = max * nums[i];
					maxSoFar = Math.Max(maxSoFar, min * nums[i]);
					max = Math.Max(1, min * nums[i]);
					min = t;
				}
			}
			return maxSoFar;
		}

		public static void Main(string[] args)
		{
			MaxProductSubarray mps = new MaxProductSubarray();
			int[] input = new int[] {-6, -3, 8, -9, -1, -1, 3, 6, 9, 0, 3, -1};
			Console.WriteLine(mps.maxProduct(input));
		}
	}

}