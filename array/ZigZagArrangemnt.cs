using LINQPad;
// Given an array of unique elements rearrange the array to be a < b > c < d > e form
public class ZigZagArrangemnt
{
    private void ArrangeZigZag(int[] array)
    {
        bool isLess = true;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (isLess)
            {
                if (array[i] > array[i + 1])
                {
                    swap(array, i, i + 1);
                }
            }
            else
            {
                if (array[i] < array[i + 1])
                {
                    swap(array, i, i + 1);
                }
            }
            isLess = !isLess;
        }

    }
    private void swap(int[] array, int firstIndex, int secondIndex)
    {
        int temp = array[firstIndex];
        array[firstIndex] = array[secondIndex];
        array[secondIndex] = temp;
    }

    public void Test()
    {
        int[] array = new int[] { 4, 5, 3, 6, 7, 9 };
        ArrangeZigZag(array);
        array.Dump();
    }
}