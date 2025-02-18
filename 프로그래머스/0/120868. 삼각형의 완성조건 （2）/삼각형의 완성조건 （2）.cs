using System;

public class Solution 
{
    public int solution(int[] sides) 
    {
        int a = sides[0];
        int b = sides[1];
        
        // 가장 작은 값과 가장 큰 값 계산
        int min = Math.Abs(a - b) + 1;
        int max = a + b - 1;
        
        // 가능한 나머지 변의 길이 개수
        return max - min + 1;
    }
}
