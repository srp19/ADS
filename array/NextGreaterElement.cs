using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.array
{
    public class NextGreaterElement
    {
        public static void printNextGreaterElement(int[] input)
        {
            Stack<int> stack = new Stack<int>();
            int inputSize = input.Length;
            stack.Push(input[0]);
            for (int i = 1; i < inputSize; i++)
            {
                while (stack.Count != 0 && stack.Peek() < input[i])
                {
                    Console.WriteLine("Next greater element for "
                                        + stack.Pop() + "\t = " + input[i]);
                }
                stack.Push(input[i]);
            }
            while (stack.Count != 0)
            {
                int top = (int)stack.Pop();
                Console.WriteLine("Next greater element for " + top + "\t = " + null);
            }
        }

        public static void Main(String[] args)
        {
            int[] input = { 98, 23, 54, 12, 20, 7, 27 };
            printNextGreaterElement(input);
        }
    }
}
