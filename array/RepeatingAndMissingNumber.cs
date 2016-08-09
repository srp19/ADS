using System;

namespace ADS.array
{

	/// <summary>
	/// http://www.geeksforgeeks.org/find-a-repeating-and-a-missing-number/
	/// </summary>
	public class RepeatingAndMissingNumber
	{

		public class Pair
		{
			private readonly RepeatingAndMissingNumber outerInstance;

			public Pair(RepeatingAndMissingNumber outerInstance)
			{
				this.outerInstance = outerInstance;
			}

			public int repeating;
			public int missing;
			public override string ToString()
			{
				return repeating + " " + missing;
			}
		}

		public virtual Pair findNumbers(int[] input)
		{
			Pair p = new Pair(this);
			for (int i = 0; i < input.Length; i++)
			{
				if (input[Math.Abs(input[i]) - 1] < 0)
				{
					p.repeating = Math.Abs(input[i]);
				}
				else
				{
					input[Math.Abs(input[i]) - 1] = -input[Math.Abs(input[i]) - 1];
				}
			}

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] < 0)
				{
					input[i] = -input[i];
				}
				else
				{
					p.missing = i + 1;
				}
			}
			return p;
		}

		public static void Main(string[] args)
		{
			RepeatingAndMissingNumber rmn = new RepeatingAndMissingNumber();
			int[] input = new int[] {3,1,2,4,6,8,2,7};
			Console.WriteLine(rmn.findNumbers(input));
		}
	}

}