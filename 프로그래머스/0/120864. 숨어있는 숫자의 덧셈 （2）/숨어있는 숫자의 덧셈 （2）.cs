using System;
using System.Text.RegularExpressions;

public class Solution 
{
    public int solution(string my_string) 
    {
        int sum = 0;
        
        // 정규식을 사용하여 연속된 숫자를 찾음
        foreach (Match match in Regex.Matches(my_string, @"\d+"))
        {
            sum += int.Parse(match.Value); // 문자열을 정수로 변환하여 합산
        }

        return sum;
    }
}
