using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.array
{


    public class SumOfDigitsEqualToGivenSum
    {
        public static void Main(String[] args)
        {
            int sum = 3, digit = 2;
            string output = string.Empty;
            generateNDigitNum(sum, digit, output);
        }
        private static void generateNDigitNum(int reducedSum, int digit, String output)
        {
            if (digit == 0 && reducedSum == 0)
            {
                Console.WriteLine(output);
                return;
            }
            else if (digit == 0 && reducedSum != 0)
            {
                return;
            }
            for (int i = reducedSum; i >= 0; i--)
            {
                if (!(i == 0 && output.Length == 0))
                {
                    generateNDigitNum(reducedSum - i, digit - 1, output + "" + i);
                }
            }
        }
        private void findNDigitNumsUtil(int n, int sum, char[] output, int index)
        {
            // Base case
            if (index > n || sum < 0)
                return;

            // If number becomes N-digit
            if (index == n)
            {
                // if sum of its digits is equal to given sum,
                // print it
                if (sum == 0)
                {
                    output[index] = '\0';
                    Console.WriteLine(new string(output));
                }
                return;
            }

            // Traverse through every digit. Note that
            // here we're considering leading 0's as digits
            for (int i = 0; i <= 9; i++)
            {
                // append current digit to number
                output[index] = (char)i;

                // recurse for next digit with reduced sum
                findNDigitNumsUtil(n, sum - i, output, index + 1);
            }
        }
        private void findNDigitNums(int n, int sum)
        {
            char[] output = new char[n + 1];
            for (int i = 1; i <= 9; i++)
            {
                output[0] = (char)i;
                findNDigitNumsUtil(n, sum - i, output, 1);
            }
        }
        //public int Main()
        //{
        //    //Input: N = 2, Sum = 3
        //    //Output: 12 21 30
        //    int n = 2, sum = 3;
        //    findNDigitNums(n, sum);
        //    return 0;
        //}
    }
}

/*
 * ---Print all n-digit numbers whose sum of digits equals to given sum
Given number of digits n, print all n-digit numbers whose sum of digits 
adds upto given sum. Solution should not consider leading 0’s as digits.

Examples:

Input:  N = 2, Sum = 3
Output:  12 21 30

Input:  N = 3, Sum = 6
Output:  105 114 123 132 141 150 204 
         213 222 231 240 303 312 321 
         330 402 411 420 501 510 600 

Input:  N = 4, Sum = 3
Output:  1002 1011 1020 1101 1110 1200
         2001 2010 2100 3000 
A simple solution would be to generate all
N-digit numbers and print numbers that
have sum of their digits equal to given sum.
The complexity of this solution would be exponential.

A better solution is to generate only those
N-digit numbers that satisfy the given constraints. 
The idea is to use recursion. We basically
fill all digits from 0 to 9 into current position
and maintain sum of digits so far. 
We then recurse for remaining sum and
number of digits left. We handle leading 0’s 
separately as they are not counted as digits.

 * */
