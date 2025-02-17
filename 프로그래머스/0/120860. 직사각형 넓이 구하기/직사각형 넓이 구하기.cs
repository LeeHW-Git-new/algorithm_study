using System;
using System.Linq;

public class Solution 
{
    public int solution(int[,] dots) 
    {
        int minX = int.MaxValue, maxX = int.MinValue;
        int minY = int.MaxValue, maxY = int.MinValue;

        for (int i = 0; i < 4; i++) 
        {
            int x = dots[i, 0];
            int y = dots[i, 1];

            minX = Math.Min(minX, x);
            maxX = Math.Max(maxX, x);
            minY = Math.Min(minY, y);
            maxY = Math.Max(maxY, y);
        }

        int width = maxX - minX;
        int height = maxY - minY;

        return width * height;
    }
}
