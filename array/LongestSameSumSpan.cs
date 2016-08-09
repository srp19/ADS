using System;
using System.Collections.Generic;

namespace ADS.array
{


	/// <summary>
	/// Date 12/29/2015
	/// @author Tushar Roy
	/// 
	/// Give two arrays of same size consisting of 0s and 1s find span (i, j) such that
	/// sum of input1[i..j] = sum of input2[i..j]
	/// 
	/// Time complexity O(n)
	/// Space complexity O(n)
	/// 
	/// http://www.geeksforgeeks.org/longest-span-sum-two-binary-arrays/
	/// </summary>
	public class LongestSameSumSpan
	{

		public virtual int longestSpan(int[] input1, int[] input2)
		{
			if (input1.Length != input2.Length)
			{
				throw new System.ArgumentException("Not same length input");
			}
			IDictionary<int?, int?> diff = new Dictionary<int?, int?>();
			int prefix1 = 0, prefix2 = 0;
			int maxSpan = 0;
			diff[0] = -1;
			for (int i = 0; i < input1.Length ; i++)
			{
				prefix1 += input1[i];
				prefix2 += input2[i];
				int currDiff = prefix1 - prefix2;
				if (diff.ContainsKey(currDiff))
				{
					maxSpan = Math.Max((int)maxSpan, (int)(i - diff[currDiff]));
				}
				else
				{
					diff[currDiff] = i;
				}
			}
			return maxSpan;
		}

		public static void Main(string[] args)
		{
			int[] input1 = new int[] {1, 0, 0, 1, 1, 0};
			int[] input2 = new int[] {0, 1, 1, 0, 1, 1};
			LongestSameSumSpan lsss = new LongestSameSumSpan();
			Console.Write(lsss.longestSpan(input1, input2));
		}

	}

}