using System;

namespace ADS.array
{

	/// <summary>
	/// Date 02/26/2016
	/// @author Tushar Roy
	/// 
	/// Time complexity : O(n^2)
	/// Space complexity : O(n)
	/// 
	/// Reference
	/// http://www.geeksforgeeks.org/form-minimum-number-from-given-sequence/
	/// </summary>
	public class MinimumNumberFromSequence
	{

		public virtual int[] find(char[] input)
		{
			int[] output = new int[input.Length + 1];
			output[0] = 1;
			int low = 0;
			int start = 0;
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == 'D')
				{
					output[i + 1] = output[i] - 1;
					if (output[i + 1] == low)
					{
						for (int j = start; j <= i + 1; j++)
						{
							output[j] = output[j] + 1;
						}
					}
				}
				else
				{
					low = output[start];
					output[i + 1] = low + 1;
					start = i + 1;
				}
			}
			return output;
		}

		public static void Main(string[] args)
		{
			MinimumNumberFromSequence ms = new MinimumNumberFromSequence();
			int[] output = ms.find("DDIDDIID".ToCharArray());
			Console.WriteLine(string.Join(",", output));

			output = ms.find("IIDDD".ToCharArray());
			Console.WriteLine(string.Join(",", output));

			output = ms.find("DIDI".ToCharArray());
			Console.WriteLine(string.Join(",", output));

		}
	}

}