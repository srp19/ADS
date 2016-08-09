using System;

namespace ADS.array
{

	/// <summary>
	/// http://www.geeksforgeeks.org/rearrange-given-array-place/
	/// </summary>
	public class RearrangeSuchThatArriBecomesArrArri
	{

		public virtual void rearrange(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				int temp;
				if (arr[arr[i]] > arr.Length - 1)
				{
					temp = arr[arr[i]] / arr.Length - 1;
				}
				else
				{
					temp = arr[arr[i]];
				}
				arr[i] = temp + arr.Length * (arr[i] + 1);
			}

			for (int i = 0; i < arr.Length;i++)
			{
				arr[i] = arr[i] % arr.Length;
			}
		}

		public static void Main(string[] args)
		{
			int[] arr = new int[] {4,2,0,1,3};
			RearrangeSuchThatArriBecomesArrArri rss = new RearrangeSuchThatArriBecomesArrArri();
			rss.rearrange(arr);
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i]);
			}
		}
	}


}