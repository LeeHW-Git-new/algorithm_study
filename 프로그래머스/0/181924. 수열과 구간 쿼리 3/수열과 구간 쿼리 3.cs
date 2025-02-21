using System;

public class Solution 
{
    public int[] solution(int[] arr, int[,] queries) 
    {
        int queryCount = queries.GetLength(0);
        
        for (int k = 0; k < queryCount; k++) 
        {
            int i = queries[k, 0];
            int j = queries[k, 1];

            // Swap elements
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        
        return arr;
    }
}
