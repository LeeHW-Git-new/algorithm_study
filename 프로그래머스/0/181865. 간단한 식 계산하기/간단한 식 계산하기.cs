using System;

public class Solution 
{
    public int solution(string binomial) {
        string[] parts = binomial.Split(' '); // 공백을 기준으로 문자열 분리
        int a = int.Parse(parts[0]); // 첫 번째 숫자
        string op = parts[1]; // 연산자
        int b = int.Parse(parts[2]); // 두 번째 숫자

        if (op == "+")
            return a + b;
        else if (op == "-")
            return a - b;
        else if (op == "*")
            return a * b;
        
        // 연산자가 잘못된 경우 예외 발생 (모든 경로에서 return 보장)
        throw new ArgumentException("Invalid operator");
    }
}
