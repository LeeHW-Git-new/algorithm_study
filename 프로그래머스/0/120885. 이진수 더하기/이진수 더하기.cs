using System;

public class Solution 
{
    public string solution(string bin1, string bin2) 
    {
        int num1 = Convert.ToInt32(bin1, 2); // 이진수를 10진수로 변환
        int num2 = Convert.ToInt32(bin2, 2); // 이진수를 10진수로 변환
        int sum = num1 + num2; // 두 값을 더하기
        return Convert.ToString(sum, 2); // 결과를 이진수 문자열로 변환
    }
}
