using System;

namespace ADS.array
{

	/// <summary>
	/// Date 03/23/2016
	/// @author Tushar Roy
	/// 
	/// Convert an unsorted array into an array of form num[0] < num[1] > nums[2] < num[3]....
	/// 
	/// Time complexity O(n) - This depends on KthElementInArray time
	/// Space complexity O(1)
	/// 
	/// https://leetcode.com/problems/wiggle-sort/
	/// https://leetcode.com/problems/wiggle-sort-ii/
	/// </summary>
	public class WiggleSort
	{

		public virtual void wiggleSort(int[] arr)
		{
			if (arr.Length == 0)
			{
				return;
			}
			int k = arr.Length / 2;
			KthElementInArray kthElementInArray = new KthElementInArray();
			kthElementInArray.kthElement(arr, k);

			int mid = arr[k];
			int n = arr.Length;
			int i = 0, j = 0;
			k = n - 1;
			while (j <= k)
			{
				if (arr[next(j, n)] > mid)
				{
					swap(arr, next(i++, n), next(j++, n));
				}
				else if (arr[next(j, n)] < mid)
				{
					swap(arr, next(j, n), next(k--, n));
				}
				else
				{
					j++;
				}
			}
		}

		//in this version we are looking for nums[0] <= nums[1] >= nums[2] <= nums[3] and so on.
		public virtual void wiggleSort1(int[] nums)
		{
			for (int i = 1; i < nums.Length; i++)
			{
				int a = nums[i - 1];
				if ((i % 2 == 1) == (a > nums[i]))
				{
					nums[i - 1] = nums[i];
					nums[i] = a;
				}
			}
		}

		private int next(int index, int n)
		{
			return (2 * index + 1) % (n | 1);
		}

		private void swap(int[] arr, int low, int high)
		{
			int temp = arr[low];
			arr[low] = arr[high];
			arr[high] = temp;
		}

		public static void Main(string[] args)
		{
			WiggleSort ws = new WiggleSort();
			int[] input = new int[] {6, 2, 1, 6, 8, 9, 6};
			ws.wiggleSort(input);
			Console.Write(string.Join(",", input));
		}
	}

}