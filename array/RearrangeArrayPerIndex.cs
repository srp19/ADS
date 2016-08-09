using System;
using System.Linq;
namespace ADS.array
{

	/// <summary>
	/// Date 12/30/2015
	/// 
	/// Given an array of size n where elements are in range 0 to n-1. Rearrange elements of array
	/// such that if arr[i] = j then arr[j] becomes i.
	/// 
	/// Time complexity O(n)
	/// Space complexity O(1)
	/// 
	/// http://www.geeksforgeeks.org/rearrange-array-arrj-becomes-arri-j/
	/// </summary>
	public class RearrangeArrayPerIndex
	{

		public virtual void rearrange(int[] input)
		{

			for (int i = 0; i < input.Length; i++)
			{
				input[i]++;
			}

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] > 0)
				{
					rearrangeUtil(input, i);
				}
			}

			for (int i = 0; i < input.Length; i++)
			{
				input[i] = -input[i] - 1;
			}
		}

		private void rearrangeUtil(int[] input, int start)
		{
			int i = start + 1;
			int v = input[start];
			while (v > 0)
			{
				int t = input[v - 1];
				input[v - 1] = -i;
				i = v;
				v = t;
			}
		}

		public static void Main(string[] args)
		{
			RearrangeArrayPerIndex rai = new RearrangeArrayPerIndex();
			int[] input = new int[] {1, 2, 0, 5, 3, 4};
			rai.rearrange(input);
			input.ToList().ForEach(i => Console.Write(i + " "));
		}

	}

}