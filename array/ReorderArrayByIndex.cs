using System;
using System.Linq;
namespace ADS.array
{

	/// <summary>
	/// Date 12/29/2015
	/// @author Tushar Roy
	/// 
	/// Given two arrays one with values and other with index where values should be positioned. Move values to correct
	/// position
	/// 
	/// Time complexity - O(n)
	/// Space complexity - O(1)
	/// 
	/// http://www.geeksforgeeks.org/reorder-a-array-according-to-given-indexes/
	/// </summary>
	public class ReorderArrayByIndex
	{
		public virtual void reorder(int[] input, int[] index)
		{
			if (index.Length != input.Length)
			{
				throw new System.ArgumentException();
			}
			for (int i = 0 ; i < index.Length; i++)
			{
				while (index[i] != i)
				{
					int sIndex = index[index[i]];
					int sVal = input[index[i]];

					index[index[i]] = index[i];
					input[index[i]] = input[i];

					index[i] = sIndex;
					input[i] = sVal;
				}
			}
		}

		public static void Main(string[] args)
		{
			int[] input = new int[] {50, 40, 70, 60, 90};
			int[] index = new int[] {3, 0, 4, 1, 2};
			ReorderArrayByIndex reorderArrayByIndex = new ReorderArrayByIndex();
			reorderArrayByIndex.reorder(input, index);
			input.ToList().ForEach(i => Console.Write(i + " "));
			Console.WriteLine();
			index.ToList().ForEach(i => Console.Write(i + " "));
		}
	}

}