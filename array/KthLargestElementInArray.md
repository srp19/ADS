--------------------Main(88)
public static void Main(String[] args)
{
    /*
     * Kth largest element in an array.
     * Use quickselect of quicksort to find the solution
     *  in hopefully O(nlogn) time.
     * Test cases
     * Sorted array
     * Reverse sorted array
     */
    int[] arr = { 4, 3, 2, 1 };
    KthElementInArray kthElement = 
        new KthElementInArray();
args =  {""}
arr = 
4	3	2	1
0	1	2	3
kthElement =  {ADS.array.KthElementInArray}
--------------------kthElement(19)
public int kthElement(int[] arr, int k)
arr = 
4	3	2	1
0	1	2	3
k =  2
low =  0
high =  0
pos =  0
--------------------kthElement(22)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
arr = 
4	3	2	1
0	1	2	3
k =  2
low =  0
high =  3
pos =  0
--------------------kthElement(25)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
--------------------quickSelect(44)
private int quickSelect(int[] arr, int low, int high)
arr = 
4	3	2	1
0	1	2	3
low =  0
high =  3
pivot =  0
--------------------quickSelect(47)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
    low++;
arr = 
4	3	2	1
0	1	2	3
low =  1
high =  3
pivot =  0
--------------------quickSelect(52)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
    low++;
    while (low <= high)
    {
        if (arr[pivot] > arr[low])
        {
            low++;
arr = 
4	3	2	1
0	1	2	3
low =  2
high =  3
pivot =  0
--------------------quickSelect(52)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
    low++;
    while (low <= high)
    {
        if (arr[pivot] > arr[low])
        {
            low++;
arr = 
4	3	2	1
0	1	2	3
low =  3
high =  3
pivot =  0
--------------------quickSelect(52)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
    low++;
    while (low <= high)
    {
        if (arr[pivot] > arr[low])
        {
            low++;
arr = 
4	3	2	1
0	1	2	3
low =  4
high =  3
pivot =  0
--------------------quickSelect(63)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
    low++;
    while (low <= high)
    {
        if (arr[pivot] > arr[low])
        {
            low++;
            continue;
        }
        if (arr[pivot] <= arr[high])
        {
            high--;
            continue;
        }
        swap(arr, low, high);
    }
    if (arr[high] < arr[pivot])
    {
--------------------swap(69)
private void swap(int[] arr, int low, int high)
arr = 
4	3	2	1
0	1	2	3
low =  0
high =  3
temp =  0
--------------------swap(71)
private void swap(int[] arr, int low, int high)
{
    int temp = arr[low];
arr = 
4	3	2	1
0	1	2	3
low =  0
high =  3
temp =  4
--------------------swap(72)
private void swap(int[] arr, int low, int high)
{
    int temp = arr[low];
    arr[low] = arr[high];
arr = 
1	3	2	1
0	1	2	3
low =  0
high =  3
temp =  4
--------------------swap(73)
private void swap(int[] arr, int low, int high)
{
    int temp = arr[low];
    arr[low] = arr[high];
    arr[high] = temp;
arr = 
1	3	2	4
0	1	2	3
low =  0
high =  3
temp =  4
--------------------quickSelect(63)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
    low++;
    while (low <= high)
    {
        if (arr[pivot] > arr[low])
        {
            low++;
            continue;
        }
        if (arr[pivot] <= arr[high])
        {
            high--;
            continue;
        }
        swap(arr, low, high);
    }
    if (arr[high] < arr[pivot])
    {
arr = 
1	3	2	4
0	1	2	3
low =  4
high =  3
pivot =  0
--------------------quickSelect(66)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
    low++;
    while (low <= high)
    {
        if (arr[pivot] > arr[low])
        {
            low++;
            continue;
        }
        if (arr[pivot] <= arr[high])
        {
            high--;
            continue;
        }
        swap(arr, low, high);
    }
    if (arr[high] < arr[pivot])
    {
        swap(arr, pivot, high);
    }
    return high;
--------------------kthElement(25)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
ADS.array.KthElementInArray.quickSelect returned =  3
arr = 
1	3	2	4
0	1	2	3
k =  2
low =  0
high =  3
pos =  0
--------------------kthElement(26)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
        pos = quickSelect(arr, low, high);
arr = 
1	3	2	4
0	1	2	3
k =  2
low =  0
high =  3
pos =  3
--------------------kthElement(34)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
        pos = quickSelect(arr, low, high);
        if (pos == (k + low))
        {
            int arrPos = arr[pos];
            return arrPos;
        }
        if (pos > k + low)
        {
            high = pos - 1;
arr = 
1	3	2	4
0	1	2	3
k =  2
low =  0
high =  2
pos =  3
--------------------kthElement(40)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
        pos = quickSelect(arr, low, high);
        if (pos == (k + low))
        {
            int arrPos = arr[pos];
            return arrPos;
        }
        if (pos > k + low)
        {
            high = pos - 1;
        }
        else
        {
            k = k - (pos - low + 1);
            low = pos + 1;
        }
--------------------kthElement(25)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
--------------------quickSelect(44)
private int quickSelect(int[] arr, int low, int high)
arr = 
1	3	2	4
0	1	2	3
low =  0
high =  2
pivot =  0
--------------------quickSelect(47)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
    low++;
arr = 
1	3	2	4
0	1	2	3
low =  1
high =  2
pivot =  0
--------------------quickSelect(57)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
    low++;
    while (low <= high)
    {
        if (arr[pivot] > arr[low])
        {
            low++;
            continue;
        }
        if (arr[pivot] <= arr[high])
        {
            high--;
arr = 
1	3	2	4
0	1	2	3
low =  1
high =  1
pivot =  0
--------------------quickSelect(57)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
    low++;
    while (low <= high)
    {
        if (arr[pivot] > arr[low])
        {
            low++;
            continue;
        }
        if (arr[pivot] <= arr[high])
        {
            high--;
arr = 
1	3	2	4
0	1	2	3
low =  1
high =  0
pivot =  0
--------------------quickSelect(66)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
    low++;
    while (low <= high)
    {
        if (arr[pivot] > arr[low])
        {
            low++;
            continue;
        }
        if (arr[pivot] <= arr[high])
        {
            high--;
            continue;
        }
        swap(arr, low, high);
    }
    if (arr[high] < arr[pivot])
    {
        swap(arr, pivot, high);
    }
    return high;
--------------------kthElement(25)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
ADS.array.KthElementInArray.quickSelect returned =  0
arr = 
1	3	2	4
0	1	2	3
k =  2
low =  0
high =  2
pos =  3
--------------------kthElement(26)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
        pos = quickSelect(arr, low, high);
arr = 
1	3	2	4
0	1	2	3
k =  2
low =  0
high =  2
pos =  0
--------------------kthElement(38)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
        pos = quickSelect(arr, low, high);
        if (pos == (k + low))
        {
            int arrPos = arr[pos];
            return arrPos;
        }
        if (pos > k + low)
        {
            high = pos - 1;
        }
        else
        {
            k = k - (pos - low + 1);
arr = 
1	3	2	4
0	1	2	3
k =  1
low =  0
high =  2
pos =  0
--------------------kthElement(39)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
        pos = quickSelect(arr, low, high);
        if (pos == (k + low))
        {
            int arrPos = arr[pos];
            return arrPos;
        }
        if (pos > k + low)
        {
            high = pos - 1;
        }
        else
        {
            k = k - (pos - low + 1);
            low = pos + 1;
arr = 
1	3	2	4
0	1	2	3
k =  1
low =  1
high =  2
pos =  0
--------------------kthElement(40)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
        pos = quickSelect(arr, low, high);
        if (pos == (k + low))
        {
            int arrPos = arr[pos];
            return arrPos;
        }
        if (pos > k + low)
        {
            high = pos - 1;
        }
        else
        {
            k = k - (pos - low + 1);
            low = pos + 1;
        }
--------------------kthElement(25)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
--------------------quickSelect(44)
private int quickSelect(int[] arr, int low, int high)
arr = 
1	3	2	4
0	1	2	3
low =  1
high =  2
pivot =  0
--------------------quickSelect(46)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
arr = 
1	3	2	4
0	1	2	3
low =  1
high =  2
pivot =  1
--------------------quickSelect(47)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
    low++;
arr = 
1	3	2	4
0	1	2	3
low =  2
high =  2
pivot =  1
--------------------quickSelect(52)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
    low++;
    while (low <= high)
    {
        if (arr[pivot] > arr[low])
        {
            low++;
arr = 
1	3	2	4
0	1	2	3
low =  3
high =  2
pivot =  1
--------------------quickSelect(63)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
    low++;
    while (low <= high)
    {
        if (arr[pivot] > arr[low])
        {
            low++;
            continue;
        }
        if (arr[pivot] <= arr[high])
        {
            high--;
            continue;
        }
        swap(arr, low, high);
    }
    if (arr[high] < arr[pivot])
    {
--------------------swap(69)
private void swap(int[] arr, int low, int high)
arr = 
1	3	2	4
0	1	2	3
low =  1
high =  2
temp =  0
--------------------swap(71)
private void swap(int[] arr, int low, int high)
{
    int temp = arr[low];
arr = 
1	3	2	4
0	1	2	3
low =  1
high =  2
temp =  3
--------------------swap(72)
private void swap(int[] arr, int low, int high)
{
    int temp = arr[low];
    arr[low] = arr[high];
arr = 
1	2	2	4
0	1	2	3
low =  1
high =  2
temp =  3
--------------------swap(73)
private void swap(int[] arr, int low, int high)
{
    int temp = arr[low];
    arr[low] = arr[high];
    arr[high] = temp;
arr = 
1	2	3	4
0	1	2	3
low =  1
high =  2
temp =  3
--------------------quickSelect(63)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
    low++;
    while (low <= high)
    {
        if (arr[pivot] > arr[low])
        {
            low++;
            continue;
        }
        if (arr[pivot] <= arr[high])
        {
            high--;
            continue;
        }
        swap(arr, low, high);
    }
    if (arr[high] < arr[pivot])
    {
arr = 
1	2	3	4
0	1	2	3
low =  3
high =  2
pivot =  1
--------------------quickSelect(66)
private int quickSelect(int[] arr, int low, int high)
{
    int pivot = low;
    low++;
    while (low <= high)
    {
        if (arr[pivot] > arr[low])
        {
            low++;
            continue;
        }
        if (arr[pivot] <= arr[high])
        {
            high--;
            continue;
        }
        swap(arr, low, high);
    }
    if (arr[high] < arr[pivot])
    {
        swap(arr, pivot, high);
    }
    return high;
--------------------kthElement(25)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
ADS.array.KthElementInArray.quickSelect returned =  2
arr = 
1	2	3	4
0	1	2	3
k =  1
low =  1
high =  2
pos =  0
--------------------kthElement(26)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
        pos = quickSelect(arr, low, high);
arr = 
1	2	3	4
0	1	2	3
k =  1
low =  1
high =  2
pos =  2
--------------------kthElement(27)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
        pos = quickSelect(arr, low, high);
        if (pos == (k + low))
arr = 
1	2	3	4
0	1	2	3
k =  1
low =  1
high =  2
pos =  2
arrPos =  0
--------------------kthElement(29)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
        pos = quickSelect(arr, low, high);
        if (pos == (k + low))
        {
            int arrPos = arr[pos];
arr = 
1	2	3	4
0	1	2	3
k =  1
low =  1
high =  2
pos =  2
arrPos =  3
--------------------kthElement(41)
public int kthElement(int[] arr, int k)
{
    int low = 0;
    int high = arr.Length - 1;
    int pos = 0;
    while (true)
    {
        pos = quickSelect(arr, low, high);
        if (pos == (k + low))
        {
            int arrPos = arr[pos];
            return arrPos;
        }
        if (pos > k + low)
        {
            high = pos - 1;
        }
        else
        {
            k = k - (pos - low + 1);
            low = pos + 1;
        }
    }
arr = 
1	2	3	4
0	1	2	3
k =  1
low =  1
high =  2
pos =  2