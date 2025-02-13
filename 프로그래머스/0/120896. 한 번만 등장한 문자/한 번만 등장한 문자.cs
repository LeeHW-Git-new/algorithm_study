using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public string solution(string s) 
    {
        // 문자 빈도수를 저장할 딕셔너리 생성
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // 문자열을 순회하며 문자 빈도수 계산
        foreach (char c in s)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        // 한 번만 등장하는 문자 추출 및 정렬
        string result = new string(charCount.Where(x => x.Value == 1)
                                            .Select(x => x.Key)
                                            .OrderBy(c => c)
                                            .ToArray());

        return result;
    }
}
