using System;

namespace ADS.array
{

	/// <summary>
	/// http://www.geeksforgeeks.org/find-number-of-triangles-possible/
	/// </summary>
	public class NumberOfTrianglesInUnsortedArray
	{

		public virtual int numberOfTriangles(int[] input)
		{
			Array.Sort(input);

			int count = 0;
			for (int i = 0; i < input.Length - 2; i++)
			{
				int k = i + 2;
				for (int j = i + 1; j < input.Length; j++)
				{
					while (k < input.Length && input[i] + input[j] > input[k])
					{
						k++;
					}
					count += k - j - 1;
				}
			}
			return count;

		}

		public static void Main(string[] args)
		{
			int[] input = new int[] {3, 4, 5, 6, 8, 9, 15};
			NumberOfTrianglesInUnsortedArray not = new NumberOfTrianglesInUnsortedArray();
			Console.WriteLine(not.numberOfTriangles(input));
		}
	}

}