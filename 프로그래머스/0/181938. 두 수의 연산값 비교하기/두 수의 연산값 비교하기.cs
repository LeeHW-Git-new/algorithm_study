using System;

public class Solution 
{
    public int solution(int a, int b) 
    {
        int concatValue = int.Parse($"{a}{b}");
        int productValue = 2 * a * b; 

        return Math.Max(concatValue, productValue); // 더 큰 값을 반환
    }
}