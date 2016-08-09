using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.array
{


	/// <summary>
	/// Date 03/12/2016
	/// @author Tushar Roy
	/// 
	/// Given an array of words and a length L, format the text such that each line has exactly L characters and is fully
	/// (left and right) justified.
	/// You should pack your words in a greedy approach; that is, pack as many words as you can in each line.
	/// 
	/// Time complexity - O(n) where n is the number of words
	/// Space complexity - O(1)
	/// 
	/// https://leetcode.com/problems/text-justification/
	/// </summary>
	public class GreedyTextJustification
	{
		public virtual IList<string> fullJustify(string[] words, int maxWidth)
		{
			IList<string> result = new List<string>();
			for (int i = 0; i < words.Length;)
			{
				int total = words[i].Length;
				int j = i + 1;
				StringBuilder buff = new StringBuilder();
				buff.Append(words[i]);
				while (j < words.Length && total + words[j].Length + 1 <= maxWidth)
				{
					total += words[j].Length + 1;
					j++;
				}
				int remaining = maxWidth - total;
				//since j is not word length means its not a last line. So pad accordingly.
				if (j != words.Length)
				{
					int count = j - i - 1;
					if (count == 0)
					{
						padSpace(buff, remaining);
					}
					else
					{
						int q = remaining / count;
						int r = remaining % count;
						for (int k = i + 1; k < j; k++)
						{
							padSpace(buff, q);
							if (r > 0)
							{
								buff.Append(" ");
								r--;
							}
							buff.Append(" ").Append(words[k]);
						}
					}
				}
				else
				{ //if it is last line then left justify all the words.
					for (int k = i + 1; k < j; k++)
					{
						buff.Append(" ").Append(words[k]);
					}
					padSpace(buff, remaining);
				}
				result.Add(buff.ToString());
				i = j;
			}
			return result;
		}

		private void padSpace(StringBuilder buff, int count)
		{
			for (int i = 0; i < count; i++)
			{
				buff.Append(" ");
			}
		}

		public static void Main(string[] args)
		{
			string[] input = new string[] {"What","must","be","shall","be."};
			GreedyTextJustification gtj = new GreedyTextJustification();
			IList<string> result = gtj.fullJustify(input, 12);
			Console.Write(result);
		}
	}

}