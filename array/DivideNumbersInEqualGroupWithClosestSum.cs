using System;
using System.Collections.Generic;

namespace ADS.array
{

	/// <summary>
	/// This solution is incorrect. It is greedy approach which will not work
	/// e.g 1,6,6,8,9,10 - Result should be 1,9,10 and 6,6,8 but it will not give this result
	/// since it will greedily break 9 and 10 into different sets
	/// 
	/// INCORRECT SOLUTION.(Still keeping the code in case I can improve it)
	/// 
	/// </summary>

	public class DivideNumbersInEqualGroupWithClosestSum
	{

		public virtual void divide(int[] arr, IList<int?> list1, IList<int?> list2)
		{
			Array.Sort(arr);
			int len = arr.Length;
			int sum1 = 0;
			int sum2 = 0;
			for (int i = len - 1 ; i >= 0; i--)
			{
				if ((sum1 < sum2 && list1.Count < len / 2) || (list2.Count >= len / 2))
				{
					list1.Add(arr[i]);
					sum1 = sum1 + arr[i];
				}
				else
				{
					list2.Add(arr[i]);
					sum2 = sum2 + arr[i];
				}
			}
		}

		public static void Main(string[] args)
		{
			IList<int?> list1 = new List<int?>();
			IList<int?> list2 = new List<int?>();
			int[] arr = new int[] {15,14,13,1,3,2};
			int[] arr1 = new int[] {23, 45, 34, 12,11, 98, 99, 4, 189, 1,7,19,105, 201};

			DivideNumbersInEqualGroupWithClosestSum dn = new DivideNumbersInEqualGroupWithClosestSum();
			dn.divide(arr, list1, list2);
			Console.WriteLine(list1);
			Console.WriteLine(list2);

			list1.Clear();
			list2.Clear();
			dn.divide(arr1, list1, list2);
			Console.WriteLine(list1);
			Console.WriteLine(list2);

		}
	}

}