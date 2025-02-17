using System;

public class Solution 
{
    public int solution(int balls, int share) 
    {
        if (share > balls - share) 
        {
            share = balls - share; // C(n, r) = C(n, n-r)
        }
        
        long result = 1;
        for (int i = 0; i < share; i++) 
        {
            result *= (balls - i);
            result /= (i + 1);
        }
        
        return (int)result;
    }
}
