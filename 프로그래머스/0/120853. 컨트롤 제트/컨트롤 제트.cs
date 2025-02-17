using System;

public class Solution 
{
    public int solution(string s) 
    {
        string[] tokens = s.Split(' '); // 공백을 기준으로 문자열을 나눔
        int sum = 0;
        int lastNum = 0; // 직전 숫자 추적

        foreach (string token in tokens) 
        {
            if (token == "Z") 
            {
                sum -= lastNum; // 직전 숫자 제거
            } 
            else 
            {
                lastNum = int.Parse(token);
                sum += lastNum;
            }
        }

        return sum;
    }
}
