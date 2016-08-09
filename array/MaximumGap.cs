using System;

namespace ADS.array
{

	/// <summary>
	/// Date 03/12/2016
	/// @author Tushar Roy
	/// 
	/// Given an unsorted array find maximum gap between consecutive element in sorted array.
	/// 
	/// Time complexity O(n)
	/// Space complexity O(n)
	/// 
	/// Reference
	/// https://leetcode.com/problems/maximum-gap/
	/// </summary>
	public class MaximumGap
	{

		public class Bucket
		{
			private readonly MaximumGap outerInstance;

			public Bucket(MaximumGap outerInstance)
			{
				this.outerInstance = outerInstance;
			}

			public int low;
			public int high;
			public bool isSet = false;
			public virtual void update(int val)
			{
				if (!isSet)
				{
					low = val;
					high = val;
					isSet = true;
				}
				else
				{
					low = Math.Min(low, val);
					high = Math.Max(high, val);
				}
			}
		}

		public virtual int maximumGap(int[] input)
		{
			if (input == null || input.Length < 2)
			{
				return 0;
			}
			int min = int.MaxValue;
			int max = int.MinValue;

			for (int i = 0; i < input.Length; i++)
			{
				min = Math.Min(min, input[i]);
				max = Math.Max(max, input[i]);
			}

			int gap = (int) Math.Ceiling((double)(max - min) / (input.Length - 1));

			Bucket[] buckets = new Bucket[input.Length - 1];

			for (int i = 0; i < buckets.Length; i++)
			{
				buckets[i] = new Bucket(this);
			}

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == max || input[i] == min)
				{
					continue;
				}
				buckets[(input[i] - min) / gap].update(input[i]);
			}

			int prev = min;
			int maxGap = 0;
			for (int i = 0; i < buckets.Length; i++)
			{
				if (!buckets[i].isSet)
				{
					continue;
				}
				maxGap = Math.Max(maxGap, buckets[i].low - prev);
				prev = buckets[i].high;
			}

			return Math.Max(maxGap, max - prev);
		}

		public static void Main(string[] args)
		{
			int[] input = new int[] {4, 3, 13, 2, 9, 7};
			MaximumGap mg = new MaximumGap();
			Console.WriteLine(mg.maximumGap(input));
		}
	}

}