using System;

public class Solution 
{
    public int solution(int[,] lines) 
    {
        int answer = 0;

        // 선분의 범위는 -100부터 100까지이므로, 그 범위에 맞는 크기의 배열 생성
        int[] lineCoverage = new int[201]; // -100 ~ 100은 인덱스 0 ~ 200에 대응

        // 각 선분의 범위에 대해 1씩 증가
        for (int i = 0; i < lines.GetLength(0); i++) 
        {
            int start = lines[i, 0] + 100; // -100을 0으로 변환
            int end = lines[i, 1] + 100;   // -100을 0으로 변환
            for (int j = start; j < end; j++) // 선분의 구간을 1씩 증가
            {
                lineCoverage[j]++;
            }
        }

        // 겹치는 구간을 계산 (2개 이상의 선분이 포함된 구간)
        foreach (var coverage in lineCoverage)
        {
            if (coverage >= 2) // 두 개 이상의 선분이 겹치는 구간
            {
                answer++;
            }
        }

        return answer;
    }
}
