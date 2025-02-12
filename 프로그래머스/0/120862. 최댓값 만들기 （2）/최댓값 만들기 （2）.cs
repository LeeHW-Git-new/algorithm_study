using System;

public class Solution 
{
    public int solution(int[] numbers) 
    {
        
        int min = 0;
        int max = 0;
        
        Array.Sort(numbers);
        
        min = numbers[0] * numbers[1];
        max = numbers[numbers.Length-1] * numbers[numbers.Length-2];
        
        int answer = Math.Max(min,max);
        
        return answer;
    }
}