using System;
using System.Linq;
namespace ADS.array
{

	/// <summary>
	/// Date 12/31/2015
	/// @author Tushar Roy
	/// 
	/// Given an array of positive and negative integers arrange them alternatively maintaining initial order.
	/// If there are more +ve or -ve integer then push them to the end together.
	/// 
	/// Time complexity is O(n)
	/// Space complexity is O(1)
	/// 
	/// http://www.geeksforgeeks.org/rearrange-array-alternating-positive-negative-items-o1-extra-space/
	/// </summary>
	public class PositiveAndNegativeNumberAlternativelyMaintainingOrder
	{

		public virtual void rearrange(int[] input)
		{

			for (int i = 0; i < input.Length; i++)
			{
				if (i % 2 == 0 && input[i] >= 0)
				{
					int indexOfNextNegative = findNext(input, i + 1, false);
					if (indexOfNextNegative == -1)
					{
						return;
					}
					else
					{
						rightRotate(input, i, indexOfNextNegative);
					}
				}
				else if (i % 2 != 0 && input[i] < 0)
				{
					int indexOfNextPositive = findNext(input, i + 1, true);
					if (indexOfNextPositive == -1)
					{
						return;
					}
					else
					{
						rightRotate(input, i, indexOfNextPositive);
					}
				}
			}
		}

		private int findNext(int[] input, int start, bool isPositive)
		{
			for (int i = start; i < input.Length; i++)
			{
				if ((isPositive && input[i] >= 0) || (!isPositive && input[i] < 0))
				{
					return i;
				}
			}
			return -1;
		}

		private void rightRotate(int[] input, int start, int end)
		{
			int t = input[end];
			for (int i = end; i > start; i--)
			{
				input[i] = input[i - 1];
			}
			input[start] = t;
		}

		public static void Main(string[] args)
		{
			int[] input = new int[] {-5, -2, 5, 2, 4, 7, 1, 8, 0, -8};
			PositiveAndNegativeNumberAlternativelyMaintainingOrder pss = new PositiveAndNegativeNumberAlternativelyMaintainingOrder();
			pss.rearrange(input);
			input.ToList().ForEach(i => Console.Write(i + " "));
		}
	}

}