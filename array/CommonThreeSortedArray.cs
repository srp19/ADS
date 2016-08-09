using System;
using System.Collections.Generic;
using System.Linq;
namespace ADS.array
{


	/// <summary>
	/// Date 01/01/2016
	/// @author Tushar Roy
	/// 
	/// Given 3 sorted array find common elements in these 3 sorted array.
	/// 
	/// Time complexity is O(m + n + k)
	/// 
	/// http://www.geeksforgeeks.org/find-common-elements-three-sorted-arrays/
	/// </summary>
	public class CommonThreeSortedArray
	{

		public virtual IList<int?> commonElements(int[] input1, int[] input2, int[] input3)
		{
			int i = 0;
			int j = 0;
			int k = 0;
			IList<int?> result = new List<int?>();
			while (i < input1.Length && j < input2.Length && k < input3.Length)
			{
				if (input1[i] == input2[j] && input2[j] == input3[k])
				{
					result.Add(input1[i]);
					i++;
					j++;
					k++;
				}
				else if (input1[i] < input2[j])
				{
					i++;
				}
				else if (input2[j] < input3[k])
				{
					j++;
				}
				else
				{
					k++;
				}
			}
			return result;
		}

		public static void Main(string[] args)
		{
			int[] input1 = new int[] {1, 5, 10, 20, 40, 80};
			int[] input2 = new int[] {6, 7, 20, 80, 100};
			int[] input3 = new int[] {3, 4, 15, 20, 30, 70, 80, 120};

			CommonThreeSortedArray cts = new CommonThreeSortedArray();
			IList<int?> result = cts.commonElements(input1, input2, input3);
			result.ToList().ForEach(i => Console.Write(i + " "));
		}
	}

}