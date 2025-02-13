using System;

public class Solution 
{
    public int solution(int i, int j, int k) 
    {
        int count = 0;
        char target = k.ToString()[0]; // k를 문자(char)로 변환

        for (int num = i; num <= j; num++) 
        {
            string numStr = num.ToString(); // 숫자를 문자열로 변환
            foreach (char c in numStr) 
            {
                if (c == target) count++; // k와 같은 문자 발견 시 카운트 증가
            }
        }

        return count;
    }
}
