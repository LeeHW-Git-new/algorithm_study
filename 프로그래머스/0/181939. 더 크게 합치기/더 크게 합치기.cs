using System;

public class Solution 
{
    public int solution(int a, int b) 
    {
        // 두 정수를 문자열로 변환 후 붙여서 비교
        int ab = int.Parse(a.ToString() + b.ToString());
        int ba = int.Parse(b.ToString() + a.ToString());
        
        return Math.Max(ab, ba);
    }
}
