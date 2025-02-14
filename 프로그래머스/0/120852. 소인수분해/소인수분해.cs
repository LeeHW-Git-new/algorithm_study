using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int n) 
    {
        List<int> list = new List<int>();
        
        // 2부터 n의 제곱근까지 반복 (최적화)
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) // i가 n의 약수라면
            {
                list.Add(i); // 리스트에 추가
                while (n % i == 0) // 같은 소인수로 계속 나눔
                {
                    n /= i;
                }
            }
        }
        // 마지막으로 n이 소수로 남아 있다면 추가
        if (n > 1)
        {
            list.Add(n);
        }
        
        return list.ToArray();
    }
}
