using System;

namespace ADS.array
{

	/// <summary>
	/// Given an array of n integers nums and a target, find the number of index triplets i, j, k
	/// with 0 <= i < j < k < n that satisfy the condition nums[i] + nums[j] + nums[k] < target.
	/// 
	/// https://leetcode.com/problems/3sum-smaller/
	/// </summary>
	public class ThreeSumSmallerThanTarget
	{
		public virtual int threeSumSmaller(int[] nums, int target)
		{
			if (nums.Length < 3)
			{
				return 0;
			}
			Array.Sort(nums);
			int count = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				int j = i + 1;
				int k = nums.Length - 1;
				while (j < k)
				{
					if (nums[i] + nums[j] + nums[k] >= target)
					{
						k--;
					}
					else
					{
						count += k - j;
						j++;
					}
				}
			}
			return count;
		}
	}

}