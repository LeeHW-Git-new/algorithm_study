using System;

public class Solution 
{
    public int solution(int[] numbers, int k) 
    {
        int index = (2 * (k - 1)) % numbers.Length;
        return numbers[index];
    }
}
