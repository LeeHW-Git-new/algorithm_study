using System;

public class Solution 
{
    public int solution(string myString, string pat) 
    {
        // 'A'를 'B'로, 'B'를 'A'로 변환
        char[] converted = myString.ToCharArray();
        for (int i = 0; i < converted.Length; i++) 
        {
            converted[i] = (converted[i] == 'A') ? 'B' : 'A';
        }
        
        // 변환된 문자열 생성
        string convertedStr = new string(converted);

        // 변환된 문자열에 pat이 포함되는지 확인
        return convertedStr.Contains(pat) ? 1 : 0;
    }
}
