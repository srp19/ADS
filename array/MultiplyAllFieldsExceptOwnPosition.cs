namespace ADS.array
{

	/// <summary>
	/// http://www.careercup.com/question?id=5179916190482432
	/// Look out for division by 0
	/// </summary>
	public class MultiplyAllFieldsExceptOwnPosition
	{

		public virtual int[] multiply(int[] nums)
		{
			if (nums.Length == 0)
			{
				return new int[0];
			}
			int[] output = new int[nums.Length];
			int product = nums[0];
			for (int i = 1; i < nums.Length; i++)
			{
				output[i] = product;
				product *= nums[i];
			}

			output[0] = 1;
			product = nums[nums.Length - 1];
			for (int i = nums.Length - 2; i >= 0; i--)
			{
				output[i] *= product;
				product *= nums[i];
			}
			return output;
		}
	}

}