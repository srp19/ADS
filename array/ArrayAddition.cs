using System;

namespace ADS.array
{

	public class ArrayAddition
	{

		public virtual int[] add(int[] arr1, int[] arr2)
		{
			int l = Math.Max(arr1.Length, arr2.Length);
			int[] result = new int[l];
			int c = 0;
			int i = arr1.Length - 1;
			int j = arr2.Length - 1;
			int r = 0;
			l--;
			while (i >= 0 && j >= 0)
			{
				r = arr1[i--] + arr2[j--] + c;
				c = r / 10;
				result[l--] = r % 10;
			}
			while (i >= 0)
			{
				r = arr1[i--] + c;
				c = r / 10;
				result[l--] = r % 10;
			}
			while (j >= 0)
			{
				r = arr2[j--] + c;
				c = r / 10;
				result[l--] = r % 10;
			}
			if (c != 0)
			{
				int[] newResult = new int[result.Length + 1];
				for (int t = newResult.Length - 1; t > 0; t--)
				{
					newResult[t] = result[t - 1];
				}
				newResult[0] = c;
				return newResult;
			}
			return result;
		}

		public static void Main(string[] args)
		{

			int[] arr1 = new int[] {9,9,9,9,9,9,9};
			int[] arr2 = new int[] {1,6,8,2,6,7};
			ArrayAddition aa = new ArrayAddition();
			int[] result = aa.add(arr1, arr2);
			for (int i = 0; i < result.Length; i++)
			{
				Console.Write(" " + result[i]);
			}
		}
	}

}