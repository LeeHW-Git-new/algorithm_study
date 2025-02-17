using System;

public class Solution 
{
    public int solution(int[] common) 
    {
        int n = common.Length;
        
        // 등차수열 여부 확인
        int diff = common[1] - common[0];
        if (common[2] - common[1] == diff) 
        {
            return common[n - 1] + diff; // 등차수열의 다음 항
        }

        // 등비수열의 다음 항
        int ratio = common[1] / common[0];
        return common[n - 1] * ratio;
    }
}
