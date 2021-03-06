﻿//using System;

//namespace ADS.array
//{

//	/// <summary>
//	/// Kth largest element in an array.
//	/// Use quickselect of quicksort to find the solution in hopefully O(nlogn) time.
//	/// Test cases
//	/// Sorted array
//	/// Reverse sorted array
//	/// </summary>
//	public class KthElementInArray
//	{

//		public virtual int kthElement(int[] arr, int k)
//		{
//			int low = 0;
//			int high = arr.Length - 1;
//			int pos = 0;
//			while (true)
//			{
//				pos = quickSelect(arr,low,high);
//				if (pos == (k + low))
//				{
//					return arr[pos];
//				}
//				if (pos > k + low)
//				{
//					high = pos - 1;
//				}
//				else
//				{
//					k = k - (pos - low + 1);
//					low = pos + 1;
//				}
//			}
//		}

//		private int quickSelect(int[] arr, int low, int high)
//		{
//			int pivot = low;
//			low++;
//			while (low <= high)
//			{
//				if (arr[pivot] > arr[low])
//				{
//					low++;
//					continue;
//				}
//				if (arr[pivot] <= arr[high])
//				{
//					high--;
//					continue;
//				}
//				swap(arr,low,high);
//			}
//			if (arr[high] < arr[pivot])
//			{
//				swap(arr,pivot,high);
//			}
//			return high;
//		}

//		private void swap(int[] arr, int low, int high)
//		{
//			int temp = arr[low];
//			arr[low] = arr[high];
//			arr[high] = temp;
//		}

//		public static void Main(string[] args)
//		{
//			int[] arr = new int[] {6, 2, 1, 6, 8, 9, 6};
//			KthElementInArray kthElement = new KthElementInArray();
//			Console.Write(kthElement.kthElement(arr, arr.Length / 2));
//			Console.Write(Arrays.ToString(arr));
//		}

//	}

//}