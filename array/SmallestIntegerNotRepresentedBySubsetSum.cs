using System;

namespace ADS.array
{

	/// <summary>
	/// Date 12/31/2015
	/// @author Tushar Roy
	/// 
	/// Given array in non decreasing order find smallest integer which cannot be represented by
	/// subset sum of these integers.
	/// 
	/// Time complexity is O(n)
	/// 
	/// http://www.geeksforgeeks.org/find-smallest-value-represented-sum-subset-given-array/
	/// </summary>
	public class SmallestIntegerNotRepresentedBySubsetSum
	{

		public virtual int findSmallestInteger(int[] input)
		{
			int result = 1;
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] <= result)
				{
					result += input[i];
				}
				else
				{
					break;
				}
			}
			return result;
		}

		/// <summary>
		/// Leetcode variation https://leetcode.com/problems/patching-array/
		/// </summary>
		public virtual int minPatches(int[] nums, int n)
		{
			int patch = 0;
			long t = 1;
			int i = 0;
			while (t <= n)
			{
				if (i == nums.Length || t < nums[i])
				{
					patch++;
					t += t;
				}
				else
				{
					t = nums[i] + t;
					i++;
				}
			}
			return patch;
		}


		public static void Main(string[] args)
		{
			int[] input = new int[] {1, 2, 3, 8};
			SmallestIntegerNotRepresentedBySubsetSum ss = new SmallestIntegerNotRepresentedBySubsetSum();
			Console.WriteLine(ss.findSmallestInteger(input));

			int[] input1 = new int[] {};
			Console.WriteLine(ss.minPatches(input1, 7));
		}
	}

}