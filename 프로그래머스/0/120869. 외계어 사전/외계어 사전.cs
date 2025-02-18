using System;
using System.Linq;

public class Solution 
{
    public int solution(string[] spell, string[] dic) 
    {
        // spell 배열의 알파벳을 모두 포함하는 단어가 dic에 있는지 확인
        return dic.Any(word => spell.All(c => word.Contains(c)) && word.Length == spell.Length) ? 1 : 2;
    }
}
