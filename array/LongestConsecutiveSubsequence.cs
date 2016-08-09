using System;
using System.Collections.Generic;

namespace ADS.array
{


	/// <summary>
	/// Date 12/03/2016
	/// @author Tushar Roy
	/// 
	/// Find longest consecutive subsequence in unsorted array.
	/// 
	/// Time complexity O(n)
	/// Space complexity O(n)
	/// 
	/// Reference
	/// https://leetcode.com/problems/longest-consecutive-sequence/
	/// </summary>
	public class LongestConsecutiveSubsequence
	{
		public virtual int longestConsecutive(int[] nums)
		{
			IDictionary<int?, int?> map = new Dictionary<int?, int?>();
			int result = 1;
			foreach (int i in nums)
			{
				if (map.ContainsKey(i))
				{
					continue;
				}
				int left = (int)(map.ContainsKey(i - 1) ? map[i - 1] : 0);
				int right = (int)(map.ContainsKey(i + 1) ? map[i + 1] : 0);

				int sum = left + right + 1;
				map[i] = sum;
				result = Math.Max(sum, result);
				map[i - left] = sum;
				map[i + right] = sum;
			}
			return result;
		}

		public static void Main(string[] args)
		{
			LongestConsecutiveSubsequence lcs = new LongestConsecutiveSubsequence();
			int[] input = new int[] {100, 4, 200, 1, 3, 2};
			Console.WriteLine(lcs.longestConsecutive(input));
		}
	}
}