//using System;

//namespace ADS.array
//{

//	/// <summary>
//	/// https://leetcode.com/problems/first-missing-positive/
//	/// </summary>
//	public class FirstPositiveMissing
//	{
//		public virtual int firstMissingPositive(int[] nums)
//		{
//			int startOfPositive = segregate(nums);
//			for (int i = startOfPositive; i < nums.Length; i++)
//			{
//				int index = Math.Abs(nums[i]) + startOfPositive - 1;
//				if (index < nums.Length)
//				{
//					nums[index] = -Math.Abs(nums[index]);
//				}
//			}
//			for (int i = startOfPositive; i < nums.Length; i++)
//			{
//				if (nums[i] > 0)
//				{
//					return i - startOfPositive + 1;
//				}
//			}
//			return nums.Length - startOfPositive + 1;
//		}

//		private int segregate(int[] nums)
//		{
//			int start = 0;
//			int end = nums.Length - 1;
//			while (start <= end)
//			{
//				if (nums[start] <= 0)
//				{
//					start++;
//				}
//				else if (nums[end] > 0)
//				{
//					end--;
//				}
//				else
//				{
//					swap(nums, start, end);
//				}
//			}
//			return start;
//		}

//		private void swap(int[] nums, int start, int end)
//		{
//			int t = nums[start];
//			nums[start] = nums[end];
//			nums[end] = t;
//		}
//	}

//}