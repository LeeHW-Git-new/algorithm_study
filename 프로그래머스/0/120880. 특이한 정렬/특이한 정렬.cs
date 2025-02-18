using System;

public class Solution 
{
    public int[] solution(int[] numlist, int n) 
    {
        // Comparison 델리게이트를 사용하여 정렬 기준을 정의
        Array.Sort(numlist, (a, b) => 
        {
            // n과의 절대 차이가 같으면 큰 값을 먼저
            int distanceA = Math.Abs(a - n);
            int distanceB = Math.Abs(b - n);
            
            // 거리가 같다면, 더 큰 수가 우선
            if (distanceA == distanceB)
                return b - a;  // 내림차순 정렬
            else
                return distanceA - distanceB;  // 오름차순 정렬
        });
        
        return numlist;
    }
}
