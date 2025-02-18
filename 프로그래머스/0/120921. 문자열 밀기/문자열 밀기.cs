using System;

public class Solution 
{
    public int solution(string A, string B) 
    {
        // A와 B의 길이가 같지 않으면 바로 -1 반환
        if (A.Length != B.Length)
            return -1;
        
        // 문자열 A를 최대 길이만큼 밀어보면서 B와 비교
        for (int i = 0; i < A.Length; i++)
        {
            if (A == B)
                return i;
            
            // A를 오른쪽으로 한 칸 밀기
            A = A[A.Length - 1] + A.Substring(0, A.Length - 1);
        }
        
        // 밀어도 B가 안되면 -1 반환
        return -1;
    }
}
