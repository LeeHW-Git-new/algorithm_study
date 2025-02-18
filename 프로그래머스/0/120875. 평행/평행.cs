using System;

public class Solution 
{
    public int solution(int[,] dots) 
    {
        // 6가지 경우의 기울기를 비교해야 합니다.
        // 기울기 비교: (y2 - y1) * (x4 - x3) == (y4 - y3) * (x2 - x1)
        
        // 첫 번째 직선 (dots[0] -> dots[1])
        // 두 번째 직선 (dots[2] -> dots[3]) 등
        if ((dots[0, 1] - dots[1, 1]) * (dots[2, 0] - dots[3, 0]) == (dots[2, 1] - dots[3, 1]) * (dots[0, 0] - dots[1, 0])) 
            return 1; // 첫 번째와 두 번째 직선이 평행
        
        // 첫 번째 직선 (dots[0] -> dots[2])
        // 두 번째 직선 (dots[1] -> dots[3]) 등
        if ((dots[0, 1] - dots[2, 1]) * (dots[1, 0] - dots[3, 0]) == (dots[1, 1] - dots[3, 1]) * (dots[0, 0] - dots[2, 0])) 
            return 1; // 첫 번째와 세 번째 직선이 평행
        
        // 첫 번째 직선 (dots[0] -> dots[3])
        // 두 번째 직선 (dots[1] -> dots[2]) 등
        if ((dots[0, 1] - dots[3, 1]) * (dots[1, 0] - dots[2, 0]) == (dots[1, 1] - dots[2, 1]) * (dots[0, 0] - dots[3, 0])) 
            return 1; // 첫 번째와 네 번째 직선이 평행
        
        return 0; // 평행하는 직선이 없음
    }
}
