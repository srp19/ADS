using System;

namespace ADS.array
{


	/// <summary>
	/// Convert an unsorted array into an array such that
	/// a < b > c < d > e < f and so on
	/// </summary>
	public class ConvertAnArrayIntoDecreaseIncreaseFashion
	{

		public virtual void convert(int[] arr)
		{
			int k = 0;
			if (arr.Length % 2 == 0)
			{
				k = arr.Length / 2;
			}
			else
			{
				k = arr.Length / 2 + 1;
			}
			KthElementInArray kthElement = new KthElementInArray();
			kthElement.kthElement(arr, k);

			int high = k;
			int low = 1;
			while (low < high && high < arr.Length)
			{
				swap(arr,low,high);
				high++;
				low += 2;
			}

		}

		/// <summary>
		/// Sort the array first.
		/// Then swap every adjacent element to get final result </summary>
		/// <param name="arr"> </param>
		public virtual void convert1(int[] arr)
		{
			Array.Sort(arr);
			for (int i = 1; i < arr.Length; i += 2)
			{
				if (i + 1 < arr.Length)
				{
					swap(arr, i, i + 1);
				}
			}
		}

		private void swap(int[] arr, int low, int high)
		{
			int temp = arr[low];
			arr[low] = arr[high];
			arr[high] = temp;
		}

		public static void Main(string[] args)
		{
			ConvertAnArrayIntoDecreaseIncreaseFashion can = new ConvertAnArrayIntoDecreaseIncreaseFashion();
			int[] arr = new int[] {0,6,9,13,10,-1,8,2,4,14,-5};
			can.convert(arr);
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();
			int[] arr1 = new int[] {0,6,9,13,10,-1,8,2,4,14,-5};
			can.convert1(arr1);
			for (int i = 0; i < arr1.Length; i++)
			{
				Console.Write(arr1[i] + " ");
			}
		}

	}

}