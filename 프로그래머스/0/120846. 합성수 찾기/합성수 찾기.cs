using System;

public class Solution 
{
    public int solution(int n) 
    {
        int count = 0;

        for (int i = 1; i <= n; i++) 
        {
            if (GetDivisorCount(i) >= 3) 
            {
                count++; // 합성수면 개수 증가
            }
        }

        return count;
    }

    // 약수 개수를 구하는 함수
    private int GetDivisorCount(int num) 
    {
        int divisorCount = 0;

        for (int i = 1; i <= num; i++) 
        {
            if (num % i == 0) 
            {
                divisorCount++;
            }
        }

        return divisorCount;
    }
}
