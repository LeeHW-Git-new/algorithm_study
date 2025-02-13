using System;

public class Solution 
{
    public int solution(int n) 
    {
        int answer = 1;
        int fact = 1; // i! 값을 계산할 변수

        for (int i = 1; ; i++) 
        {
            fact *= i; // i! 계산
            if (fact > n) break; // n을 초과하면 중단
            answer = i; // 현재 i가 조건을 만족하는 최댓값
        }

        return answer;
    }
}