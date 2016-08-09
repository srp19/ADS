using System;

namespace ADS.array
{

	/// <summary>
	/// http://www.geeksforgeeks.org/find-the-minimum-distance-between-two-numbers/
	/// </summary>
	public class MinimumDistanceBetweenTwoNumbers
	{

		public virtual int minDistance(int[] input, int x, int y)
		{
			int prev = -1;
			int prevFound = -1;
			int min = 10000;
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == x)
				{
					if (prevFound == -1)
					{
						prevFound = x;
						prev = i;
					}
					else if (prevFound == x)
					{
						prev = i;
					}
					else
					{
						min = min > i - prev ? i - prev : min;
						prev = i;
						prevFound = x;
					}
				}
				else if (input[i] == y)
				{
					if (prevFound == -1)
					{
						prevFound = y;
						prev = i;
					}
					else if (prevFound == y)
					{
						prev = i;
					}
					else
					{
						min = min > i - prev ? i - prev : min;
						prevFound = y;
						prev = i;
					}
				}
			}
			return min;
		}

		public static void Main(string[] args)
		{
			MinimumDistanceBetweenTwoNumbers mdb = new MinimumDistanceBetweenTwoNumbers();
			int[] input = new int[] {6,4,1,5,6,9,10,4,6,6};
			Console.WriteLine(mdb.minDistance(input, 5, 6));
		}
	}

}