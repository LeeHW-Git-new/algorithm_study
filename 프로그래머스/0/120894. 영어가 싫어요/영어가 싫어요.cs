using System;
using System.Collections.Generic;

public class Solution 
{
    public long solution(string numbers) 
    {
        // 영어 단어와 숫자의 매핑
        Dictionary<string, string> numMap = new Dictionary<string, string>()
        {
            {"zero", "0"}, {"one", "1"}, {"two", "2"}, {"three", "3"}, {"four", "4"},
            {"five", "5"}, {"six", "6"}, {"seven", "7"}, {"eight", "8"}, {"nine", "9"}
        };

        // 문자열 변환
        foreach (var pair in numMap)
        {
            numbers = numbers.Replace(pair.Key, pair.Value);
        }

        return long.Parse(numbers);
    }
}
