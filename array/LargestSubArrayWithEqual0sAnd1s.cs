using System;
using System.Collections.Generic;

namespace ADS.array
{


	/// <summary>
	/// http://www.geeksforgeeks.org/largest-subarray-with-equal-number-of-0s-and-1s/
	/// Test cases
	/// Starting with either 0 or 1
	/// Maximum length of 0 1 2 or more
	/// 
	/// </summary>
	public class LargestSubArrayWithEqual0sAnd1s
	{

		public virtual int equalNumber(int[] arr)
		{

			int[] sum = new int[arr.Length];
			sum[0] = arr[0] == 0? - 1 : 1;
			for (int i = 1; i < sum.Length; i++)
			{
				sum[i] = sum[i - 1] + (arr[i] == 0? - 1 : 1);
			}

			IDictionary<int?, int?> pos = new Dictionary<int?, int?>();
			int maxLen = 0;
			int i1 = 0;
			foreach (int s in sum)
			{
				if (s == 0)
				{
					maxLen = Math.Max(maxLen, i1 + 1);
				}
				if (pos.ContainsKey(s))
				{
					maxLen = Math.Max((int)maxLen, (int) (i1 - pos[s]));
				}
				else
				{
					pos[s] = i1;
				}
				i1++;
			}
			return maxLen;
		}

		public static void Main(string[] args)
		{
			int[] arr = new int[] {0,0,0,1,0,1,0,0,1,0,0,0};
			LargestSubArrayWithEqual0sAnd1s mse = new LargestSubArrayWithEqual0sAnd1s();
			Console.WriteLine(mse.equalNumber(arr));
		}

	}

}