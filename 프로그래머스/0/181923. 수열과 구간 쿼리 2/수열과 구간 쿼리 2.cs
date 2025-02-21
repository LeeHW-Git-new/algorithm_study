using System;

public class Solution 
{
    public int[] solution(int[] arr, int[,] queries) 
    {
        int queryCount = queries.GetLength(0);
        int[] result = new int[queryCount];
        
        for (int q = 0; q < queryCount; q++) 
        {
            int s = queries[q, 0];
            int e = queries[q, 1];
            int k = queries[q, 2];
            
            int minValue = int.MaxValue;
            bool found = false;
            
            for (int i = s; i <= e; i++) 
            {
                if (arr[i] > k && arr[i] < minValue) 
                {
                    minValue = arr[i];
                    found = true;
                }
            }
            
            result[q] = found ? minValue : -1;
        }
        
        return result;
    }
}