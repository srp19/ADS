using System;

namespace ADS.array
{

	/// <summary>
	/// http://www.geeksforgeeks.org/maximum-contiguous-circular-sum/
	/// Test cases
	/// All negative
	/// All positives
	/// all 0s
	/// </summary>

	public class Triplet
	{
		public int start;
		public int end;
		public int sum;
		public override string ToString()
		{
			return "Triplet [start=" + start + ", end=" + end + ", sum=" + sum + "]";
		}

	}
	public class KadaneWrapArray
	{

		public virtual Triplet kadaneWrap(int[] arr)
		{
			Triplet straightKadane = kadane(arr);
			int sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
				arr[i] = -arr[i];
			}
			Triplet wrappedNegKadane = kadane(arr);
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = -arr[i];
			}
			if (straightKadane.sum < sum + wrappedNegKadane.sum)
			{
				straightKadane.sum = wrappedNegKadane.sum + sum;
				straightKadane.start = wrappedNegKadane.end + 1;
				straightKadane.end = wrappedNegKadane.start - 1;
			}
			return straightKadane;
		}

		/// <summary>
		/// This method assumes there is at least one positive number in the array.
		/// Otherwise it will break </summary>
		/// <param name="arr">
		/// @return </param>
		public virtual Triplet kadane(int[] arr)
		{
			int sum = 0;
			int cStart = 0;
			int mStart = 0;
			int end = 0;
			int maxSum = int.MinValue;
			for (int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
				if (sum <= 0)
				{
					sum = 0;
					cStart = i + 1;
				}
				else
				{
					if (sum > maxSum)
					{
						maxSum = sum;
						mStart = cStart;
						end = i;
					}
				}
			}
			Triplet p = new Triplet();
			p.sum = maxSum;
			p.start = mStart;
			p.end = end;
			return p;
		}

		public static void Main(string[] args)
		{
			KadaneWrapArray kwa = new KadaneWrapArray();
			int[] input = new int[] {12, -2, -6, 5, 9, -7, 3};
			int[] input1 = new int[] {8, -8, 9, -9, 10, -11, 12};
			Console.WriteLine(kwa.kadaneWrap(input));
			Console.WriteLine(kwa.kadaneWrap(input1));
		}
	}

}