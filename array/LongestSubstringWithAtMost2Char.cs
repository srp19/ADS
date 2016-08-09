using System;

namespace ADS.array
{

	/// <summary>
	/// Longest Substring with At Most Two Distinct Characters
	/// https://leetcode.com/problems/longest-substring-with-at-most-two-distinct-characters/
	/// </summary>
	public class LongestSubstringWithAtMost2Char
	{
		public virtual int lengthOfLongestSubstringTwoDistinct(string s)
		{
			int count1 = 0;
			int count2 = 0;
			char c1 = (char)0;
			char c2 = (char)0;
			int start = 0;
			int current = 0;
			int max = 0;
			foreach (char ch in s.ToCharArray())
			{
				if (ch == c1 || ch == c2)
				{
					if (ch == c1)
					{
						count1++;
					}
					else
					{
						count2++;
					}
				}
				else
				{
					if (count1 != 0 && count2 != 0)
					{
						while (start < current)
						{
							if (s[start] == c1)
							{
								count1--;
							}
							else if (s[start] == c2)
							{
								count2--;
							}
							start++;
							if (count1 == 0 || count2 == 0)
							{
								break;
							}
						}
					}
					if (count1 == 0)
					{
						c1 = ch;
						count1 = 1;
					}
					else
					{
						c2 = ch;
						count2 = 1;
					}
				}
				max = Math.Max(max, current - start + 1);
				current++;
			}
			return max;
		}

		public static void Main(string[] args)
		{
			LongestSubstringWithAtMost2Char lc = new LongestSubstringWithAtMost2Char();
			Console.Write(lc.lengthOfLongestSubstringTwoDistinct("eceba"));
		}
	}
}