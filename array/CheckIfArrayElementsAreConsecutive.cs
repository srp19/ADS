using System;

namespace ADS.array
{

	/// <summary>
	/// http://www.geeksforgeeks.org/check-if-array-elements-are-consecutive/
	/// </summary>
	public class CheckIfArrayElementsAreConsecutive
	{

		public virtual bool areConsecutive(int[] input)
		{
			int min = int.MaxValue;
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] < min)
				{
					min = input[i];
				}
			}
			for (int i = 0; i < input.Length; i++)
			{
				if (Math.Abs(input[i]) - min >= input.Length)
				{
					return false;
				}
				if (input[Math.Abs(input[i]) - min] < 0)
				{
					return false;
				}
				input[Math.Abs(input[i]) - min] = -input[Math.Abs(input[i]) - min];
			}
			for (int i = 0; i < input.Length ; i++)
			{
				input[i] = Math.Abs(input[i]);
			}
			return true;
		}

		public static void Main(string[] args)
		{
			int[] input = new int[] {76,78,76,77,73,74};
			CheckIfArrayElementsAreConsecutive cia = new CheckIfArrayElementsAreConsecutive();
			Console.WriteLine(cia.areConsecutive(input));
		}
	}

}