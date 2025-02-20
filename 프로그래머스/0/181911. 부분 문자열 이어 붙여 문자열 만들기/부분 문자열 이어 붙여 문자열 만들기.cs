using System;

public class Solution 
{
    public string solution(string[] my_strings, int[,] parts) 
    {
        string answer = "";

        for (int i = 0; i < my_strings.Length; i++)
        {
            int s = parts[i, 0]; // 시작 인덱스
            int e = parts[i, 1]; // 끝 인덱스
            answer += my_strings[i].Substring(s, e - s + 1); // 부분 문자열 추출 및 추가
        }

        return answer;
    }
}