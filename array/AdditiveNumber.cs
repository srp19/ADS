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

            numberStr = "199100";
            Console.WriteLine(numberStr + " is Additive number? " + IsAdditiveNumber(numberStr));

            numberStr = "11";
            Console.WriteLine(numberStr + " is Additive number? " + IsAdditiveNumber(numberStr));

            numberStr = "110203";
            Console.WriteLine(numberStr + " is Additive number? " + IsAdditiveNumber(numberStr));
        }
        public bool IsAdditiveNumber(string numberStr)
        {
            int totalChars = numberStr.Length;
            //number of characters at a time. [1] [11] ...
            for (int noOfFirstStrChars = 1; noOfFirstStrChars <= totalChars / 2; noOfFirstStrChars++)
            {
                if (noOfFirstStrChars > 1 && numberStr[0] == '0') return false;
                long num1 = long.Parse(numberStr.Substring(0, noOfFirstStrChars));

                //number of characters at time. [1] [12] ...
                for (int noOfSecondStrChars = 1; Math.Max(noOfFirstStrChars, noOfSecondStrChars) <= 
                    totalChars - noOfFirstStrChars - noOfSecondStrChars; noOfSecondStrChars++)
                {
                    if (noOfSecondStrChars > 1 && numberStr[noOfFirstStrChars] == '0') break;

                    //first iteration 1 character at a time.. so x1 = 1 and x2 = 1
                    long num2 = long.Parse(numberStr.Substring(noOfFirstStrChars, noOfSecondStrChars));

                    //Recursively iterate the entire loop (first time with 1 character each)
                    if (isValid(num1, num2, noOfFirstStrChars + noOfSecondStrChars, numberStr)) return true;
                }
            }
            return false;
        }
        private bool isValid(long num1, long num2, int totalCharsConsidered, string numberStr)
        {
            if (totalCharsConsidered == numberStr.Length) return true;
            num2 = num2 + num1;
            num1 = num2 - num1;
            string sum = num2.ToString();
            return numberStr.Substring(totalCharsConsidered).StartsWith(sum) &&
                isValid(num1, num2, totalCharsConsidered + sum.Length, numberStr);
        }

    }
}
