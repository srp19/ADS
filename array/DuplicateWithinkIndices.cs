using System;
using System.Collections.Generic;

namespace ADS.array
{


	/// <summary>
	/// Write a function that determines whether a array contains duplicate 
	/// characters within k indices of each other
	/// </summary>
	public class DuplicateWithinkIndices
	{

		public virtual bool duplicate(int[] arr, int k)
		{
			ISet<int?> visited = new HashSet<int?>();
			for (int i = 0; i < arr.Length; i++)
			{
				if (visited.Contains(arr[i]))
				{
					return true;
				}
				if (i >= k)
				{
					visited.Remove(arr[i - k]);
				}
				visited.Add(arr[i]);
			}
			return false;
		}

		public static void Main(string[] args)
		{
			int[] arr = new int[] {1,2,3,11,2,5,6};
			DuplicateWithinkIndices dk = new DuplicateWithinkIndices();
			Console.WriteLine(dk.duplicate(arr, 3));
		}
	}

}