using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.array
{
	/*
	Given input array of 0s and 1s and number of flips allowed from 0 to 1, what is maximum consecutive 1s we can have
	in array
	
	Time complexity - O(n)
	Space complexity - O(1)
	*/
	public class Flip0sMaximum1s
	{

		public int flip0sToMaximizeConsecutive1s(int[] input, int flipsAllowed)
		{

			int windowStart = 0;
			int countZero = 0;
			int result = 0;
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == 1)
				{
					result = Math.Max(result, i - windowStart + 1);
				}
				else
				{
					if (countZero < flipsAllowed)
					{
						countZero++;
						result = Math.Max(result, i - windowStart + 1);
					}
					else
					{
						while (true)
						{
							if (input[windowStart] == 0)
							{
								windowStart++;
								break;
							}
							windowStart++;
						}
					}
				}
			}
			return result;
		}

		public static void Main(string[] args)
		{
			int[] input = new int[] { 0, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 1 };
			Flip0sMaximum1s fm = new Flip0sMaximum1s();
			Console.Write(fm.flip0sToMaximizeConsecutive1s(input, 1));
		}
	}
}
