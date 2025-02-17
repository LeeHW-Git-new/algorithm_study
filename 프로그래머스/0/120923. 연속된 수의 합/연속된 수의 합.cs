using System;

public class Solution 
{
    public int[] solution(int num, int total) 
    {
        // 연속된 숫자의 첫 번째 값 x 계산
        int start = (total - ((num - 1) * num / 2)) / num;
        
        // x부터 num개의 연속된 숫자 생성
        int[] result = new int[num];
        for (int i = 0; i < num; i++) 
        {
            result[i] = start + i;
        }
        
        return result;
    }
}
