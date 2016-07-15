Count Inversions of size three in a give array
Given an array arr[] of size n. Three elements arr[i], arr[j] and arr[k] form an inversion of size 3 if a[i] > a[j] >a[k] and i < j < k. Find total number of inversions of size 3.

Example:

Input:  {8, 4, 2, 1}
Output: 4
The four inversions are (8,4,2), (8,4,1), (4,2,1) and (8,2,1).

Input:  {9, 6, 4, 5, 8}
Output:  2
The two inversions are {9, 6, 4} and {9, 6, 5}


Simple approach :- Loop for all possible value of i, j and k and check for the condition a[i] > a[j] > a[k] and i < j < k.


We can reduce the complexity if we consider every element arr[i] as middle element of inversion, find all the numbers greater than a[i] whose index is less than i, find all the numbers which are smaller than a[i] and index is more than i. We multiply the number of elements greater than a[i] to the number of elements smaller than a[i] and add it to the result.