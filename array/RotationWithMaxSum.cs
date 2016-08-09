using System;

namespace ADS.array
{

	/// <summary>
	/// Date 12/30/2015
	/// @author Tushar Roy
	/// 
	/// Given an input array find which rotation will give max sum of i * arr[i]
	/// 
	/// Time complexity - O(n)
	/// Space complexity - O(1)
	/// 
	/// http://www.geeksforgeeks.org/find-maximum-value-of-sum-iarri-with-only-rotations-on-given-array-allowed/
	/// </summary>
	public class RotationWithMaxSum
	{
		public virtual int maxSum(int[] input)
		{
			int arrSum = 0;
			int rotationSum = 0;
			for (int i = 0; i < input.Length; i++)
			{
				arrSum += input[i];
				rotationSum += i * input[i];
			}

			int maxRotationSum = rotationSum;

			for (int i = 1; i < input.Length; i++)
			{
				rotationSum += input.Length * input[i - 1] - arrSum;
				maxRotationSum = Math.Max(maxRotationSum, rotationSum);
			}
			return maxRotationSum;
		}

		public static void Main(string[] args)
		{
			int[] input = new int[] {10, 1, 2, 3, 4, 5, 6, 7, 8, 9};
			RotationWithMaxSum rms = new RotationWithMaxSum();
			Console.Write(rms.maxSum(input));
		}
	}

}