using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.array
{
    public class AdditiveNumber
    {
        public void Main()
        {
            string numberStr = "112358";
            Console.WriteLine(numberStr + " is Additive number? " + IsAdditiveNumber(numberStr));

            //numberStr = "199100";
            //Console.WriteLine(numberStr + " is Additive number? " + IsAdditiveNumber(numberStr));

            //numberStr = "11";
            //Console.WriteLine(numberStr + " is Additive number? " + IsAdditiveNumber(numberStr));

            //numberStr = "110203";
            //Console.WriteLine(numberStr + " is Additive number? " + IsAdditiveNumber(numberStr));
        }
        public bool IsAdditiveNumber(string numberStr)
        {
            int totalChars = numberStr.Length;
            //number of characters at a time. [1] [11] ...
            for (int noOfFirstSubStrChars = 1; noOfFirstSubStrChars <= totalChars / 2; noOfFirstSubStrChars++)
            {
                if (noOfFirstSubStrChars > 1 && numberStr[0] == '0') return false;
                long num1 = long.Parse(numberStr.Substring(0, noOfFirstSubStrChars));

                //number of characters at time. [1] [12] ...
                for (int noOfSecondSubStrChars = 1; Math.Max(noOfFirstSubStrChars, noOfSecondSubStrChars) <= 
                    totalChars - noOfFirstSubStrChars - noOfSecondSubStrChars; noOfSecondSubStrChars++)
                {
                    if (noOfSecondSubStrChars > 1 && numberStr[noOfFirstSubStrChars] == '0') break;

                    //first iteration 1 character at a time.. so x1 = 1 and x2 = 1
                    long num2 = long.Parse(numberStr.Substring(noOfFirstSubStrChars, noOfSecondSubStrChars));

                    //Recursively iterate the entire loop (first time with 1 character each)
                    if (isValid(num1, num2, noOfFirstSubStrChars + noOfSecondSubStrChars, numberStr)) return true;
                }
            }
            return false;
        }
        private bool isValid(long num1, long num2, int totalNoOfSubStrChars, string numberStr)
        {
            if (totalNoOfSubStrChars == numberStr.Length) return true;
            num2 = num2 + num1;
            num1 = num2 - num1;
            string sum = num2.ToString();
            string subStr = numberStr.Substring(totalNoOfSubStrChars);
            bool subStrStartsWithSum = subStr.StartsWith(sum);
            return subStrStartsWithSum &&
                isValid(num1, num2, totalNoOfSubStrChars + sum.Length, numberStr);
        }

    }
}
