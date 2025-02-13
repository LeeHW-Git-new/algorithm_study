using System;
using System.Collections.Generic;

public class Solution 
{
    public string solution(string letter) 
    {
        // 모스부호 딕셔너리 정의
        Dictionary<string, char> morseDict = new Dictionary<string, char>()
        {
            {".-", 'a'},   {"-...", 'b'}, {"-.-.", 'c'}, {"-..", 'd'}, {".", 'e'},  
            {"..-.", 'f'}, {"--.", 'g'},  {"....", 'h'}, {"..", 'i'},  {".---", 'j'},
            {"-.-", 'k'},  {".-..", 'l'}, {"--", 'm'},   {"-.", 'n'},  {"---", 'o'},  
            {".--.", 'p'}, {"--.-", 'q'}, {".-.", 'r'},  {"...", 's'}, {"-", 't'},  
            {"..-", 'u'},  {"...-", 'v'}, {".--", 'w'},  {"-..-", 'x'}, {"-.--", 'y'},  
            {"--..", 'z'}
        };

        // 공백(" ")을 기준으로 문자열을 분할하여 리스트 생성
        string[] morseWords = letter.Split(' ');

        // 모스부호를 알파벳으로 변환 후 문자열 합치기
        string result = "";
        foreach (string morse in morseWords)
        {
            if (morseDict.ContainsKey(morse))  // 딕셔너리에 존재하는 경우 변환
            {
                result += morseDict[morse];
            }
        }

        return result;
    }
}
