using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int n) 
    {
        List<int> collatzSequence = new List<int>(); // 콜라츠 수열을 저장할 리스트
        collatzSequence.Add(n); // 초기값 n을 리스트에 추가
        
        while (n != 1) // n이 1이 아닐 때까지 반복
        {
            if (n % 2 == 0) // n이 짝수일 경우
            {
                n /= 2; // 2로 나눔
            }
            else // n이 홀수일 경우
            {
                n = 3 * n + 1; // 3 * n + 1로 변경
            }
            collatzSequence.Add(n); // 계산된 n을 리스트에 추가
        }

        return collatzSequence.ToArray(); // 콜라츠 수열을 배열로 변환하여 반환
    }
}