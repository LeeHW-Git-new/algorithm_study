using System;

public class Solution 
{
    public int solution(int[,] board) 
    {
        int n = board.GetLength(0); // 배열 크기
        bool[,] danger = new bool[n, n]; // 위험지역 표시 배열

        // 지뢰가 있는 곳과 인접한 곳을 위험지역으로 표시
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i, j] == 1)
                {
                    // 지뢰 자체
                    danger[i, j] = true;

                    // 8방향 체크
                    for (int di = -1; di <= 1; di++)
                    {
                        for (int dj = -1; dj <= 1; dj++)
                        {
                            int ni = i + di;
                            int nj = j + dj;

                            // 배열 밖을 벗어나지 않도록 체크
                            if (ni >= 0 && ni < n && nj >= 0 && nj < n)
                            {
                                danger[ni, nj] = true;
                            }
                        }
                    }
                }
            }
        }

        // 안전지역 계산
        int safeCount = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (!danger[i, j]) // 위험지역이 아닌 곳
                {
                    safeCount++;
                }
            }
        }

        return safeCount;
    }
}
