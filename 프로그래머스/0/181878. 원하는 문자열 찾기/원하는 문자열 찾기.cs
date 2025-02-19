using System;

public class Solution 
{
    public int solution(string myString, string pat) 
    {
        // 대소문자 구분 없이 비교하기 위해 소문자로 변환
        string lowerMyString = myString.ToLower();
        string lowerPat = pat.ToLower();

        // 부분 문자열 포함 여부 확인
        return lowerMyString.Contains(lowerPat) ? 1 : 0;
    }
}
