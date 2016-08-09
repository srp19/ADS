using System;

namespace ADS.array
{

	/// <summary>
	/// http://www.geeksforgeeks.org/minimum-length-unsorted-subarray-sorting-which-makes-the-complete-array-sorted/
	/// </summary>
	public class MinimumSortedWhichSortsEntireArray
	{

		public virtual int minLength(int[] arr)
		{
			int i = 0;
			while (i < arr.Length - 1 && arr[i] < arr[i + 1])
			{
				i++;
			}
			if (i == arr.Length - 1)
			{
				return 0;
			}
			int j = arr.Length - 1;
			while (j > 0 && arr[j] > arr[j - 1])
			{
				j--;
			}

			int max = int.MinValue;
			int min = int.MaxValue;
			for (int k = i; k <= j; k++)
			{
				if (max < arr[k])
				{
					max = arr[k];
				}
				if (min > arr[k])
				{
					min = arr[k];
				}
			}
			int x = i - 1;
			while (x >= 0)
			{
				if (min > arr[x])
				{
					break;
				}
				x--;
			}

			int y = j + 1;
			while (y < arr.Length)
			{
				if (max < arr[y])
				{
					break;
				}
				y++;
			}
			return y - x - 2 + 1;
		}

		public static void Main(string[] args)
		{
			int[] arr = new int[] {4,5,10,21,18,23,7,8,19,34,38};
			int[] arr1 = new int[] {4,5,6,12,11,15};
			int[] arr2 = new int[] {4,5,6,10,11,15};
			MinimumSortedWhichSortsEntireArray msw = new MinimumSortedWhichSortsEntireArray();
			Console.WriteLine(msw.minLength(arr1));
		}

	}

}