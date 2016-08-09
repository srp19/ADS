using System;

namespace ADS.array
{


	/// <summary>
	/// http://www.geeksforgeeks.org/given-an-array-arr-find-the-maximum-j-i-such-that-arrj-arri/
	/// </summary>
	public class MaximumIminusJSuchThatAiGTAj
	{

		public class Node
		{
			private readonly MaximumIminusJSuchThatAiGTAj outerInstance;

			public Node(MaximumIminusJSuchThatAiGTAj outerInstance)
			{
				this.outerInstance = outerInstance;
			}

			public int index;
			public int size;
		}

		public virtual int maximumGeeks(int[] input)
		{
			int[] lhs = new int[input.Length];
			int[] rhs = new int[input.Length];
			lhs[0] = 0;
			for (int i = 1; i < lhs.Length; i++)
			{
				if (input[lhs[i - 1]] < input[i])
				{
					lhs[i] = lhs[i - 1];
				}
				else
				{
					lhs[i] = i;
				}
			}
			rhs[input.Length - 1] = input.Length - 1;
			for (int i = input.Length - 2; i >= 0; i--)
			{
				if (input[rhs[i + 1]] > input[i])
				{
					rhs[i] = rhs[i + 1];
				}
				else
				{
					rhs[i] = i;
				}
			}

			int i1 = 0;
			int j = 0;
			int max = 0;
			for (;j < input.Length;)
			{
				if (input[lhs[i1]] < input[rhs[j]])
				{
					max = Math.Max(max, j - i1);
					j++;
				}
				else
				{
					i1++;
				}
			}
			return max;
		}

		public static void Main(string[] args)
		{
			MaximumIminusJSuchThatAiGTAj mj = new MaximumIminusJSuchThatAiGTAj();
			int[] input = new int[] {11,14,13,1,4,13,1,10};
			Console.WriteLine(mj.maximumGeeks(input));
		}

	}

}