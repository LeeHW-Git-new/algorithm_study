using System;

public class Solution 
{
    public int solution(int[] arr1, int[] arr2) 
    {
        // 1. 배열 길이 비교
        if (arr1.Length > arr2.Length)
            return 1;
        else if (arr1.Length < arr2.Length)
            return -1;

        // 2. 배열 길이가 같다면, 원소 합 비교
        int sum1 = 0, sum2 = 0;

        foreach (int num in arr1)
            sum1 += num;
        
        foreach (int num in arr2)
            sum2 += num;

        // 3. 원소 합 비교
        if (sum1 > sum2)
            return 1;
        else if (sum1 < sum2)
            return -1;
        else
            return 0;
    }
}
