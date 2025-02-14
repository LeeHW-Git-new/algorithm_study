using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Solution 
{
    public int solution(string[] babbling) 
    {
        string[] words = { "aya", "ye", "woo", "ma" };
        int answer = 0;

        foreach (string babble in babbling)
        {
            string temp = babble;

            // "aya", "ye", "woo", "ma"를 모두 제거하여 빈 문자열이 되는지 확인
            foreach (string word in words)
            {
                temp = temp.Replace(word, " ");
            }

            // 모든 단어가 적절히 제거되었으면 temp가 공백이거나 빈 문자열이어야 함
            if (temp.Trim().Length == 0)
            {
                answer++;
            }
        }

        return answer;
    }
}
