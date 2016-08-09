using System;

namespace ADS.array
{

	/// <summary>
	/// http://www.geeksforgeeks.org/rearrange-positive-and-negative-numbers-publish/
	/// </summary>
	public class PositiveAndNegativeNumberAlternatively
	{

		public virtual void arrange(int[] arr)
		{
			int startOfPos = segregate(arr);

			int startOfNeg = 1;
			while (startOfNeg < startOfPos && startOfPos < arr.Length)
			{
				swap(arr,startOfNeg,startOfPos);
				startOfNeg += 2;
				startOfPos++;
			}
		}

		private int segregate(int[] arr)
		{
			int low = 0;
			int high = arr.Length - 1;
			while (low < high)
			{
				if (arr[low] < 0)
				{
					low++;
				}
				else if (arr[high] >= 0)
				{
					high--;
				}
				else
				{
					swap(arr,low,high);
				}
			}
			return low;
		}

		private void swap(int[] arr, int i, int j)
		{
			int t = arr[i];
			arr[i] = arr[j];
			arr[j] = t;
		}

		public static void Main(string[] args)
		{
			int[] arr = new int[] {-1,-2,-3,-4,-5,1,2,3,4,5};
			PositiveAndNegativeNumberAlternatively pan = new PositiveAndNegativeNumberAlternatively();
			pan.arrange(arr);
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
		}
	}

}