using System;

public class Solution 
{
    public int solution(int a, int b, int c) 
    {
        int sum = a + b + c;
        int sumSquares = (a * a) + (b * b) + (c * c);
        int sumCubes = (a * a * a) + (b * b * b) + (c * c * c);
        
        if (a == b && b == c) 
        {
            return sum * sumSquares * sumCubes;
        } 
        else if (a == b || b == c || a == c) 
        {
            return sum * sumSquares;
        } 
        else 
        {
            return sum;
        }
    }
}
