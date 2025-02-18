using System;

public class Solution 
{
    public int solution(string my_string) 
    {
        string[] tokens = my_string.Split(' '); // 공백을 기준으로 문자열을 나눔
        int result = int.Parse(tokens[0]); // 첫 번째 숫자로 초기화

        for (int i = 1; i < tokens.Length; i += 2) // 연산자 부분만 순회
        {
            string op = tokens[i]; // 연산자
            int num = int.Parse(tokens[i + 1]); // 연산자 뒤의 숫자

            if (op == "+")
                result += num;
            else if (op == "-")
                result -= num;
        }

        return result;
    }
}
