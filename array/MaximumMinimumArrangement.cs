using System;

namespace ADS.array
{

	/// <summary>
	/// Date 04/16/2016
	/// @author Tushar Roy
	/// 
	/// Given a sorted array of positive integers, rearrange the array alternately i.e first element should be maximum value,
	/// second minimum value, third second max, fourth second min and so on.
	/// 
	/// Time complexity O(n)
	/// Space complexity O(1)
	/// 
	/// http://www.geeksforgeeks.org/rearrange-array-maximum-minimum-form/
	/// </summary>
	public class MaximumMinimumArrangement
	{

		public virtual void rearrange(int[] input)
		{
			for (int i = 0; i < input.Length; i++)
			{
				int t = input[i];
				if (t < 0)
				{
					continue;
				}
				int i1 = i;
				while (true)
				{
					int j = i1 < input.Length / 2 ? 2 * i1 + 1 : (input.Length - 1 - i1) * 2;
					if (j == i1)
					{
						break;
					}
					if (input[j] < 0)
					{
						break;
					}
					int t1 = input[j];
					input[j] = -t;
					t = t1;
					i1 = j;
				}
			}

			for (int i = 0; i < input.Length; i++)
			{
				input[i] = Math.Abs(input[i]);
			}
		}
	}

}