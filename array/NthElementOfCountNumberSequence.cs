using System;
using System.Collections.Generic;

namespace ADS.array
{


	/// <summary>
	/// Date 07/20/2015
	/// @author Tushar Roy
	/// 
	/// Given a sequence like
	/// 1 11 21 1211 111221 312211
	/// Print nth element of this sequence.
	/// </summary>
	public class NthElementOfCountNumberSequence
	{

		public virtual IList<int?> nthElement(int n)
		{
			int i = 1;
			IList<int?> current = new List<int?>();
			current.Add(1);
			IList<int?> result = new List<int?>();
			while (i < n)
			{
				int count = 1;
				int index = 0;
				for (int j = 1; j < current.Count; j++)
				{
					if (current[index] == current[j])
					{
						count++;
					}
					else
					{
						result.Add(count);
						result.Add(current[index]);
						count = 1;
						index = j;
					}
				}
				result.Add(count);
				result.Add(current[index]);
				current = result;
				result = new List<int?>();
				i++;
			}
			return current;
		}

		public static void Main(string[] args)
		{
			NthElementOfCountNumberSequence nes = new NthElementOfCountNumberSequence();
			for (int i = 1 ; i <= 10; i++)
			{
				IList<int?> result = nes.nthElement(i);
				
			
			}
		}
	}

}