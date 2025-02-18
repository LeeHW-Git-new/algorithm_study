using System;

public class Solution 
{
    public int solution(int[] box, int n) 
    {
        // 각 방향에서 주사위를 몇 개씩 넣을 수 있는지 계산
        int countX = box[0] / n;
        int countY = box[1] / n;
        int countZ = box[2] / n;
        
        // 전체 주사위 개수는 세 방향에서의 개수를 곱한 값
        return countX * countY * countZ;
    }
}
