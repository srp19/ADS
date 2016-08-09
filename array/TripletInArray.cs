using System;
using System.Collections.Generic;

namespace ADS.array
{


	/// <summary>
	/// http://www.geeksforgeeks.org/find-a-triplet-that-sum-to-a-given-value/
	/// </summary>
	public class TripletInArray
	{

		public class Triplet
		{
			private readonly TripletInArray outerInstance;

			public Triplet(TripletInArray outerInstance)
			{
				this.outerInstance = outerInstance;
			}

			public int a;
			public int b;
			public int c;

			public override string ToString()
			{
				return a + " " + b + " " + c;
			}
		}

		public virtual Triplet findTriplet(int[] input, int sum)
		{
			Array.Sort(input);
			for (int i = 0; i < input.Length - 2; i++)
			{

				int start = i + 1;
				int end = input.Length - 1;
				int new_sum = sum - input[i];
				while (start < end)
				{
					if (new_sum == input[start] + input[end])
					{
						Triplet t = new Triplet(this);
						t.a = input[i];
						t.b = input[start];
						t.c = input[end];
						return t;
					}
					if (new_sum > input[start] + input[end])
					{
						start++;
					}
					else
					{
						end--;
					}
				}
			}
			return null;
		}

		/// <summary>
		/// https://leetcode.com/problems/3sum/
		/// </summary>
		public virtual IList<IList<int?>> threeSum(int[] nums)
		{
			Array.Sort(nums);
			IList<IList<int?>> result = new List<IList<int?>>();
			for (int i = 0; i < nums.Length - 2; i++)
			{
				if (i != 0 && nums[i] == nums[i - 1])
				{
					continue;
				}
				int start = i + 1;
				int end = nums.Length - 1;
				while (start < end)
				{
					if (nums[i] + nums[start] + nums[end] == 0)
					{
						IList<int?> r = new List<int?>();
						r.Add(nums[i]);
						r.Add(nums[start]);
						r.Add(nums[end]);
						result.Add(r);
						start++;
						end--;
						while (start < nums.Length && nums[start] == nums[start - 1])
						{
							start++;
						}
						while (end >= 0 && nums[end] == nums[end + 1])
						{
							end--;
						}
					}
					else if (nums[i] + nums[start] + nums[end] < 0)
					{
						start++;
					}
					else
					{
						end--;
					}
				}
			}
			return result;
		}

		public static void Main(string[] args)
		{
			TripletInArray tip = new TripletInArray();
			int[] input = new int[] {1,2,6,9,11,18,26,28};
			int sum = 22;
			Console.WriteLine(tip.findTriplet(input, sum));
		}
	}

}