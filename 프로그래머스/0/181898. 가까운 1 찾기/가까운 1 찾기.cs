using System;

public class Solution 
{
    public int solution(int[] arr, int idx) 
    {
        for (int i = idx; i < arr.Length; i++) 
        { // idx부터 탐색하도록 수정
            if (arr[i] == 1) return i;
        }
        return -1;
    }
}

