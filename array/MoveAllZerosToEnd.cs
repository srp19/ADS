using System;

namespace ADS.array
{

	public class MoveAllZerosToEnd
	{

		public virtual void moveZeros(int[] arr)
		{
			int slow = 0;
			int fast = 0;
			while (fast < arr.Length)
			{
				if (arr[fast] == 0)
				{
					fast++;
					continue;
				}
				arr[slow] = arr[fast];
				slow++;
				fast++;
			}
			while (slow < arr.Length)
			{
				arr[slow++] = 0;
			}
		}

		public static void Main(string[] args)
		{
			MoveAllZerosToEnd maz = new MoveAllZerosToEnd();
			int[] arr = new int[] {0,0,1,2,0,5,6,7,0};
			maz.moveZeros(arr);
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i]);
			}
		}
	}

}