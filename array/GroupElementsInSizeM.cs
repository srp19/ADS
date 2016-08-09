using System;
using System.Collections.Generic;

namespace ADS.array
{


	/// <summary>
	/// http://www.careercup.com/question?id=6026101998485504
	/// This answer two questions.
	/// Group elements in size m such that in every group only unique elements are possible.
	/// It also answers question where rearrange array such that same elements are exactly m
	/// distance from each other
	/// </summary>
	public class Pair
	{
		public int num;
		public int count;
		public Pair(int num, int count)
		{
			this.count = count;
			this.num = num;
		}
	}

	public class Comparators : IComparer<Pair>
	{

		public virtual int Compare(Pair o1, Pair o2)
		{
			if (o1.count <= o2.count)
			{
				return 1;
			}
			else
			{
				return -1;
			}
		}

	}

	public class GroupElementsInSizeM
	{

		public virtual bool group(int[] input, int m)
		{
			IDictionary<int?, int?> count = new Dictionary<int?, int?>();
			foreach (int? i in input)
			{
				int c = 1;
				if (count.ContainsKey(i))
				{
					c = count[i].Value;
					c++;
				}
				count[i] = c;
			}

			//PriorityQueue<Pair> maxHeap = new PriorityQueue<Pair>(count.Count,new Comparators());
			//foreach (int? s in count.Keys)
			//{
			//	int c = count[s].Value;
			//	//if any count is greater than len/m then this arrangement is not possible
			//	if (c > Math.Ceiling(input.Length * 1.0 / m))
			//	{
			//		return false;
			//	}
			//	maxHeap.offer(new Pair(s.Value, c));
			//}
			//int current = 0;
			//int start = current;
			//while (maxHeap.size() > 0)
			//{
			//	Pair p = maxHeap.poll();
			//	int i = 0;
			//	while (i < p.count)
			//	{
			//		input[start] = p.num;
			//		start = start + m;
			//		if (start >= input.Length)
			//		{
			//			current++;
			//			start = current;
			//		}
			//		i++;
			//	}
			//}
			return true;
		}

		public static void Main(string[] args)
		{
			int[] input = new int[] {2,1,5,1,3,5,3,3,4};
			int[] input1 = new int[] {1,2,3,8,8,8,7,8};
			GroupElementsInSizeM gps = new GroupElementsInSizeM();
			bool r = gps.group(input1, 3);
			Console.WriteLine(r);
			for (int i = 0; i < input1.Length; i++)
			{
				Console.WriteLine(input1[i]);
			}
		}
	}

}