using System;

public class Solution {
    public int[,] solution(int[] num_list, int n) 
    {
        int rowCount = num_list.Length / n; // 행 개수 계산
        int[,] result = new int[rowCount, n]; // 2차원 배열 생성

        for (int i = 0; i < rowCount; i++) 
        {
            for (int j = 0; j < n; j++) 
            {
                result[i, j] = num_list[i * n + j]; // num_list의 원소를 2차원 배열에 삽입
            }
        }

        return result;
    }
}
