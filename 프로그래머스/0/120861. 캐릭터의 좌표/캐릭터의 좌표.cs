using System;

public class Solution 
{
    public int[] solution(string[] keyinput, int[] board) 
    {
        // 초기 위치 (0, 0)
        int x = 0, y = 0;

        // 맵의 최대 이동 가능 범위 설정
        int xLimit = board[0] / 2;
        int yLimit = board[1] / 2;

        // 키 입력에 따른 이동
        foreach (string key in keyinput)
        {
            if (key == "left" && x > -xLimit) x--;
            else if (key == "right" && x < xLimit) x++;
            else if (key == "up" && y < yLimit) y++;
            else if (key == "down" && y > -yLimit) y--;
        }

        return new int[] { x, y };
    }
}
