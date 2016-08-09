using System;
using System.Collections.Generic;

namespace ADS.array
{


	/// <summary>
	/// Date 03/01/2016
	/// @author Tushar Roy
	/// 
	/// Given two arrays of length m and n with digits 0-9 representing two numbers.
	/// Create the maximum number of length k <= m + n from digits of the two
	/// 
	/// e.g
	/// nums1 = [3, 4, 6, 5]
	/// nums2 = [9, 1, 2, 5, 8, 3]
	/// k = 5
	/// return [9, 8, 6, 5, 3]
	/// 
	/// https://leetcode.com/problems/create-maximum-number/
	/// </summary>
	public class MaxNumberFromTwoArray
	{
		public virtual int[] maxNumber(int[] nums1, int[] nums2, int k)
		{

			int[] result = new int[k];
			//try k from nums1 and k - i from nums2.
			//Combine then by merge sort routine. And see that this result is bigger than
			//already stored result. If yes then store it as result.
			for (int i = 0; i <= nums1.Length; i++)
			{

				if (k - i < 0 || i > nums1.Length || (k - i) > nums2.Length)
				{
					continue;
				}

				int[] r1 = findMaxNumber(nums1, i);
				int[] r2 = findMaxNumber(nums2, k - i);

				int x = 0, y = 0;
				int[] r = new int[k];
				int index = 0;
				while (x < r1.Length && y < r2.Length)
				{
					//if both the numbers are equal then keep check till the end to see which one has greater
					//number following after current number.
					if (r1[x] == r2[y])
					{
						int t = x + 1;
						int u = y + 1;
						while (t < r1.Length && u < r2.Length)
						{
							if (r1[t] == r2[u])
							{
								t++;
								u++;
							}
							else
							{
								break;
							}
						}
						if (t == r1.Length || u == r2.Length)
						{
							r[index++] = (t == r1.Length ? r2[y++] : r1[x++]);
						}
						else
						{
							r[index++] = r1[t] > r2[u] ? r1[x++] : r2[y++];
						}
					}
					else if (r1[x] > r2[y])
					{
						r[index++] = r1[x++];
					}
					else if (r2[y] > r1[x])
					{
						r[index++] = r2[y++];
					}
				}

				while (x < r1.Length)
				{
					r[index++] = r1[x++];
				}

				while (y < r2.Length)
				{
					r[index++] = r2[y++];
				}

				if (isBigger(r, result))
				{
					result = r;
				}
			}

			return result;
		}

		private bool isBigger(int[] r1, int[] r2)
		{
			for (int i = 0; i < r1.Length; i++)
			{
				if (r1[i] > r2[i])
				{
					return true;
				}
				else if (r1[i] < r2[i])
				{
					return false;
				}
			}
			return false;
		}

		/// <summary>
		/// Find max number by removing k digits from input.
		/// </summary>
		private int[] findMaxNumber(int[] input, int k)
		{
			int remaining = input.Length - k;
			//Deque<int?> stack = new LinkedList<int?>();
			//for (int i = 0; i < input.Length; i++)
			//{
			//	while (!stack.Empty && remaining > 0)
			//	{
			//		if (stack.peek() < input[i])
			//		{
			//			stack.pollFirst();
			//			remaining--;
			//		}
			//		else
			//		{
			//			break;
			//		}
			//	}
			//	stack.offerFirst(input[i]);
			//}
			int[] result = new int[Math.Min(k, input.Length)];
			//for (int i = 0; i < result.Length; i++)
			//{
			//	result[i] = stack.pollLast();
			//}

			return result;
		}

		public static void Main(string[] args)
		{
			MaxNumberFromTwoArray max = new MaxNumberFromTwoArray();
			int[] input1 = new int[] {9,1,2,5,8,3};
			int[] input2 = new int[] {3,4,6,5};

			int[] input3 = new int[] {2,5,6,4,4,0};
			int[] input4 = new int[] {7,3,8,0,6,5,7,6,2};
			int[] result = max.maxNumber(input3, input4, 15);
			Console.Write(string.Join(",", result));
		}
	}
}