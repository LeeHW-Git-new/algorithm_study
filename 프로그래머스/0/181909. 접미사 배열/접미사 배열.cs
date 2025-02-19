using System;
using System.Linq;

public class Solution 
{
    public string[] solution(string my_string) 
    {
        // 모든 접미사를 리스트로 생성
        string[] suffixes = new string[my_string.Length];
        
        for (int i = 0; i < my_string.Length; i++) 
        {
            suffixes[i] = my_string.Substring(i);
        }
        
        // 사전순 정렬
        Array.Sort(suffixes);
        
        return suffixes;
    }
}
