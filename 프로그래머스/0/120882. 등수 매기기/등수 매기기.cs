using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[,] score) 
    {
        int length = score.GetLength(0);
        double[] averages = new double[length];
        
        // 평균 점수 계산
        for (int i = 0; i < length; i++)
        {
            averages[i] = (score[i, 0] + score[i, 1]) / 2.0;
        }
        
        // 등수 매기기
        var sortedAverages = averages.OrderByDescending(x => x).ToList();
        int[] ranks = new int[length];
        
        for (int i = 0; i < length; i++)
        {
            ranks[i] = sortedAverages.IndexOf(averages[i]) + 1;
        }
        
        return ranks;
    }
}
