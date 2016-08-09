namespace ADS.array
{

	/// <summary>
	/// References
	/// https://leetcode.com/problems/candy/
	/// </summary>
	public class LeetCodeCandy
	{
		public virtual int candy(int[] ratings)
		{
			int pointOfChange = 0;
			int totalCandies = 1;
			int currentCandy = 1;
			bool isIndependent = true;
			int maxHeight = 0;
			int diff = 0;
			for (int i = 1; i < ratings.Length; i++)
			{
				diff = 0;
				if (ratings[i] > ratings[i - 1])
				{
					currentCandy += 1;
				}
				else if (ratings[i] == ratings[i - 1])
				{
					isIndependent = true;
					pointOfChange = i;
					currentCandy = 1;
				}
				else
				{
					if (currentCandy == 1)
					{
						if (!isIndependent)
						{
							if (i - pointOfChange == maxHeight - 1)
							{
								pointOfChange--;
							}
						}
					}
					else
					{
						maxHeight = currentCandy;
						currentCandy = 1;
						isIndependent = false;
						pointOfChange = i;
					}
					diff = i - pointOfChange;
				}
				totalCandies += (diff + currentCandy);
			}
			return totalCandies;
		}
	}

}