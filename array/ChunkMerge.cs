using System;
using System.Collections.Generic;

namespace ADS.array
{


	/// <summary>
	/// Given a list of lists. Each element in the list is sorted. Sort the 
	/// entire list.
	/// Test cases
	/// One or more lists are empty
	/// All elements in one list are smaller than all elements in another list
	/// </summary>
	public class ChunkMerge
	{

		public class Triplet : IComparable<Triplet>
		{
			private readonly ChunkMerge outerInstance;

			public Triplet(ChunkMerge outerInstance)
			{
				this.outerInstance = outerInstance;
			}

			public int pos;
			public int val;
			public int index;
			public virtual int CompareTo(Triplet o)
			{
				if (val <= o.val)
				{
					return -1;
				}
				else
				{
					return 1;
				}
			}
		}

		public virtual IList<int?> mergeUsingHeap(IList<IList<int?>> chunks)
		{
			IList<int?> result = new List<int?>();
			PriorityQueue<Triplet> queue = new PriorityQueue<Triplet>();
			//add first element of every chunk into queue
			for (int i = 0; i < chunks.Count; i++)
			{
				Triplet p = new Triplet(this);
				p.pos = i;
				p.val = chunks[i][0];
				p.index = 1;
				queue.add(p);
			}

			while (!queue.Empty)
			{
				Triplet p = queue.poll();
				result.Add(p.val);
				if (p.index < chunks[p.pos].Count)
				{
					p.val = chunks[p.pos][p.index];
					p.index += 1;
					queue.add(p);
				}
			}
			return result;
		}

		public virtual IList<int?> mergeChunksOfDifferentSize(IList<IList<int?>> chunks)
		{
			IList<int?> result = new List<int?>();

			int[] sum = new int[chunks.Count + 1];
			sum[0] = 0;
			for (int i = 1; i < sum.Length;i++)
			{
				sum[i] = sum[i - 1] + chunks[i - 1].Count;
			}

			foreach (IList<int?> chunk in chunks)
			{
				foreach (int? i in chunk)
				{
					result.Add(i);
				}
			}
			mergeSort(result,0,chunks.Count - 1,sum);
			return result;
		}

		private void mergeSort(IList<int?> result, int start, int end, int[] sum)
		{
			if (start >= end)
			{
				return;
			}
			int mid = (start + end) / 2;
			mergeSort(result,start,mid,sum);
			mergeSort(result,mid + 1,end,sum);
			sortedMerge(result,start,end,sum);
		}

		private void sortedMerge(IList<int?> result, int start, int end, int[] sum)
		{

			/// <summary>
			/// If chunks are of equal size then
			/// i = size*start to (mid+1)*size -1
			/// j = (mid+1)*size to size*(end+1)
			/// </summary>

			int mid = (start + end) / 2;
			int i = sum[start];
			int j = sum[mid + 1];
			IList<int?> temp = new List<int?>();
			while (i < sum[mid + 1] && j < sum[end + 1])
			{
				if (result[i] < result[j])
				{
					temp.Add(result[i]);
					i++;
				}
				else
				{
					temp.Add(result[j]);
					j++;
				}
			}
			while (i < sum[mid + 1])
			{
				temp.Add(result[i]);
				i++;
			}
			while (j < sum[end + 1])
			{
				temp.Add(result[j]);
				j++;
			}
			int index = sum[start];
			foreach (int k in temp)
			{
				result[index] = k;
				index++;
			}
		}
		public static void Main(string[] args)
		{
			int?[] arr1 = new int?[] {1,5,6,9,21};
			int?[] arr2 = new int?[] {4,6,11,14};
			int?[] arr3 = new int?[] {-1,0,7};
			int?[] arr4 = new int?[] {-4,-2,11,14,18};
			int?[] arr5 = new int?[] {2,6};
			int?[] arr6 = new int?[] {-5,-2,1,5,7,11,14};
			int?[] arr7 = new int?[] {-6,-1,0,15,17,22,24};

			IList<int?> list1 = Arrays.asList(arr1);
			IList<int?> list2 = Arrays.asList(arr2);
			IList<int?> list3 = Arrays.asList(arr3);
			IList<int?> list4 = Arrays.asList(arr4);
			IList<int?> list5 = Arrays.asList(arr5);
			IList<int?> list6 = Arrays.asList(arr6);
			IList<int?> list7 = Arrays.asList(arr7);


			IList<IList<int?>> chunks = new List<IList<int?>>();
			chunks.Add(list1);
			chunks.Add(list2);
			chunks.Add(list3);
			chunks.Add(list4);
			chunks.Add(list5);
			chunks.Add(list6);
			chunks.Add(list7);

			ChunkMerge cm = new ChunkMerge();
			IList<int?> result = cm.mergeChunksOfDifferentSize(chunks);
			Console.WriteLine(result.Count);
			foreach (int? r in result)
			{
				Console.Write(r + " ");
			}

			result = cm.mergeUsingHeap(chunks);
			Console.WriteLine();
			foreach (int? r in result)
			{
				Console.Write(r + " ");
			}
		}
	}

}