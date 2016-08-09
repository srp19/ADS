using System;

namespace ADS.array
{

	/// <summary>
	/// Given an array of citations (each citation is a non-negative integer) of a researcher,
	/// write a function to compute the researcher's h-index.
	/// https://leetcode.com/problems/h-index/
	/// </summary>
	public class HIndex
	{
		public virtual int hIndex(int[] citations)
		{
			int[] count = new int[citations.Length + 1];
			foreach (int c in citations)
			{
				if (c <= citations.Length)
				{
					count[c]++;
				}
				else
				{
					count[citations.Length]++;
				}
			}

			int sum = 0;
			int max = 0;
			for (int i = 0; i < count.Length; i++)
			{
				sum += count[i];
				//we are trying to see if i is answer.
				//already everything before i has less than i citations.
				//so only thing to check is that p >= i where p is
				//total number of papers with i or more citations.
				int p = citations.Length - sum + count[i];
				if (i <= p)
				{
					max = i;
				}
			}
			return max;
		}

		public static void Main(string[] args)
		{
			HIndex hi = new HIndex();
			int[] input = new int[] {0, 1, 1, 1, 1, 6, 7,8};
			Console.Write(hi.hIndex(input));
		}
	}

	//0 1 2 6 6 6 6 7
	//0 1 2 3 4 5 6 7
	//0 1 1 1 3 6 7 8
	//0 1 2 3 4 5 6 7

	//0 1 2 5 6

}