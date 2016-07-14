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
            string num = "112358";
            Console.WriteLine(IsAdditiveNumber(num));
        }
        public bool IsAdditiveNumber(string num)
        {
            int n = num.Length;
            //number of characters at a time. [1] [11] ...
            for (int i = 1; i <= n / 2; i++)
            {
                if (num[0] == '0' && i > 1) return false;
                long x1 = long.Parse(num.Substring(0, i));

                //number of characters at time. [1] [12] ...
                for (int j = 1; Math.Max(j, i) <= n - i - j; j++)
                {
                    if (num[i] == '0' && j > 1) break;

                    //first iteration 1 character at a time.. so x1 = 1 and x2 = 1
                    long x2 = long.Parse(num.Substring(i, j));

                    //Recursively iterate the entire loop (first time with 1 character each)
                    if (isValid(x1, x2, j + i, num)) return true;
                }
            }
            return false;
        }
        private bool isValid(long x1, long x2, int start, string num)
        {
            if (start == num.Length) return true;
            x2 = x2 + x1;
            x1 = x2 - x1;
            string sum = x2.ToString();
            return num.Substring(start).StartsWith(sum) &&
                isValid(x1, x2, start + sum.Length, num);
        }

    }
}
