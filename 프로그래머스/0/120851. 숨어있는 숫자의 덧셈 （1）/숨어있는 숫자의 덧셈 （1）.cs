using System;

public class Solution 
{
    public int solution(string my_string) 
    {
        int answer = 0;
        
        foreach (char c in my_string)
        {
            if (char.IsDigit(c)) // 문자가 숫자인지 확인
            {
                answer += c - '0'; // 문자를 정수로 변환 후 더하기
            }
        }
        
        return answer;
    }
}
