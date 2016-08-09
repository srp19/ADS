using System;
using System.Text;

namespace ADS.array
{

	/// <summary>
	/// Date 03/04/2016
	/// @author Tushar Roy
	/// 
	/// How to append minimum numbers of characters in front of string to make it a palindrome.
	/// 
	/// Idea is to create a new string which is original ttring + $ + reverse of original string
	/// Get value of suffix which is also prefix using KMP.
	/// This part of string is good. Rest needs to be copied in the front.
	/// 
	/// Time complexity is O(n)
	/// Space complexity is O(n)
	/// 
	/// https://leetcode.com/problems/shortest-palindrome/
	/// </summary>
	public class ShortestPalindrome
	{
		public virtual string shortestPalindrome(string s)
		{
			char[] input = createInput(s);
			int val = kmp(input);

			StringBuilder sb = new StringBuilder();
			int remaining = s.Length - val;
			int i = s.Length - 1;
			while (remaining > 0)
			{
				sb.Append(s[i]);
				i--;
				remaining--;
			}
			sb.Append(s);
			return sb.ToString();

		}

		private int kmp(char[] input)
		{
			int[] T = new int[input.Length];

			int j = 1;
			int i = 0;

			T[0] = 0;

			while (j < input.Length)
			{
				if (input[i] == input[j])
				{
					T[j] = i + 1;
					i++;
				}
				else
				{
					while (i != 0)
					{
						i = T[i - 1];
						if (input[j] == input[i])
						{
							T[j] = i + 1;
							i++;
							break;
						}
					}
				}
				j++;
			}
			return T[input.Length - 1];
		}

		private char[] createInput(string s)
		{
			char[] input = new char[2 * s.Length + 1];
			int index = 0;
			foreach (char ch in s.ToCharArray())
			{
				input[index++] = ch;
			}
			input[index++] = '$';

			for (int i = s.Length - 1; i >= 0; i--)
			{
				input[index++] = s[i];
			}
			return input;
		}

		public static void Main(string[] args)
		{
			ShortestPalindrome sp = new ShortestPalindrome();
			Console.Write(sp.shortestPalindrome("aacecaaa"));
		}
	}

}