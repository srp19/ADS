using System;

namespace ADS.array
{

	public class StableMarriageProblem
	{

		private bool checkIfNewIsBetter(int[][] priority, int bride, int currentGroom, int suitor)
		{
			foreach (int groom in priority[bride])
			{
				if (currentGroom == groom)
				{
					return false;
				}
				if (suitor == groom)
				{
					return true;
				}
			}
			return false;
		}

		public virtual int[] findPair(int[][] priority)
		{
			int pair = priority[0].Length;
			int[] groomToBride = new int[pair];
			int[] brideToGroom = new int[pair];
			for (int i = 0; i < groomToBride.Length; i++)
			{
				groomToBride[i] = -1;
			}
			for (int i = 0; i < brideToGroom.Length; i++)
			{
				brideToGroom[i] = -1;
			}
			int groom;
			int remaingGrooms = pair;
			while (remaingGrooms > 0)
			{
				groom = -1;
				foreach (int hasBride in groomToBride)
				{
					if (hasBride != -1)
					{
						continue;
					}
					groom++;
					foreach (int bride in priority[groom])
					{
						if (brideToGroom[bride - pair] == -1)
						{
							groomToBride[groom] = bride;
							brideToGroom[bride - pair] = groom;
							remaingGrooms--;
							break;
						}
						else
						{
							bool flag = checkIfNewIsBetter(priority, bride, brideToGroom[bride - pair], groom);
							if (flag)
							{
								int currentGroom = brideToGroom[bride - pair];
								brideToGroom[bride - pair] = groom;
								groomToBride[groom] = bride;
								groomToBride[currentGroom] = -1;
							}
						}
					}
				}
			}
			return groomToBride;
		}

		public static void Main(string[] args)
		{
			int[][] priority = new int[][]
			{
				new int[] {5,4,7,6},
				new int[] {4,5,6,7},
				new int[] {5,4,6,7},
				new int[] {5,4,7,6},
				new int[] {0,1,2,3},
				new int[] {0,1,3,2},
				new int[] {0,3,1,2},
				new int[] {0,1,2,3}
			};
			StableMarriageProblem smp = new StableMarriageProblem();
			int[] result = smp.findPair(priority);
			for (int i = 0; i < result.Length; i++)
			{
				Console.WriteLine(i + " " + result[i]);
			}
		}
	}

}