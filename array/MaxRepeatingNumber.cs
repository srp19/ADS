using System;

namespace ADS.array
{

	/// <summary>
	/// http://www.geeksforgeeks.org/find-the-maximum-repeating-number-in-ok-time/
	/// Given an array of size n, the array contains numbers in range from 0 to k-1 
	/// where k is a positive integer and k <= n.
	/// Find the maximum repeating number in this array
	/// </summary>
	public class MaxRepeatingNumber
	{

		public virtual int maxRepeatingNumber(int[] arr, int k)
		{
			int len = k;
			for (int i = 0; i < arr.Length; i++)
			{
				arr[arr[i] % len] += len;
			}
			int maxRepeating = 0;
			int maxRepeatingIndex = 0;
			for (int i = 0; i < len; i++)
			{
				if (maxRepeating < arr[i])
				{
					maxRepeating = arr[i];
					maxRepeatingIndex = i;
				}
			}
			for (int i = 0; i < len; i++)
			{
				arr[i] = arr[i] % len;
			}
			return maxRepeatingIndex;
		}

		public static void Main(string[] args)
		{
			MaxRepeatingNumber mrn = new MaxRepeatingNumber();
			int[] arr = new int[] {2,2,1,3,1,2,0,3,0,0,0,4,5,4,4,4,4};
			Console.WriteLine(mrn.maxRepeatingNumber(arr, 6));
		}
	}

}