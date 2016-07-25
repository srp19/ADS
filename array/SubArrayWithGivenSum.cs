using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.array
{
    /// <summary>
	/// http://www.geeksforgeeks.org/find-subarray-with-given-sum/
	/// </summary>
	public class SubarrayWithGivenSum
    {

        public class Pair
        {
            private readonly SubarrayWithGivenSum outerInstance;

            public Pair(SubarrayWithGivenSum outerInstance)
            {
                this.outerInstance = outerInstance;
            }

            internal int start;
            internal int end;

            public override string ToString()
            {
                return start + " " + end;
            }
        }
        public virtual Pair findSubArray(int[] input, int sum)
        {
            int currentSum = 0;
            Pair p = new Pair(this);
            p.start = 0;
            for (int i = 0; i < input.Length; i++)
            {
                currentSum += input[i];
                p.end = i;
                if (currentSum == sum)
                {
                    return p;
                }
                else if (currentSum > sum)
                {
                    int s = p.start;
                    while (currentSum > sum)
                    {
                        currentSum -= input[s];
                        s++;
                    }
                    p.start = s;
                    if (currentSum == sum)
                    {
                        return p;
                    }
                }
            }
            return null;
        }

        public static void Main(string[] args)
        {
            SubarrayWithGivenSum sgs = new SubarrayWithGivenSum();
            int[] input = new int[] { 6, 3, 9, 11, 1, 3, 5 };
            Console.WriteLine(sgs.findSubArray(input, 15));
        }
    }
}
