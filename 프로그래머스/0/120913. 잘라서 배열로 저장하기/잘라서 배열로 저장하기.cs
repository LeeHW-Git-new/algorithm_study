using System;
using System.Collections.Generic;

public class Solution 
{
    public string[] solution(string my_str, int n) 
    {
        List<string> result = new List<string>(); // 결과 저장 리스트

        for (int i = 0; i < my_str.Length; i += n) 
        {
            // 남은 길이가 n보다 작으면 나머지 부분만 저장
            result.Add(my_str.Substring(i, Math.Min(n, my_str.Length - i)));
        }
        
        return result.ToArray(); // 리스트를 배열로 변환 후 반환
    }
}
