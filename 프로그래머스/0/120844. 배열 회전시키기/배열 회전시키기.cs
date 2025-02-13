using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) 
    {
        int length = numbers.Length;
        int[] rotated = new int[length];

        if (direction == "right")
        {
            rotated[0] = numbers[length - 1]; // 마지막 원소를 첫 번째 위치로 이동
            Array.Copy(numbers, 0, rotated, 1, length - 1); // 나머지 원소를 오른쪽으로 이동
        }
        else if (direction == "left")
        {
            Array.Copy(numbers, 1, rotated, 0, length - 1); // 첫 번째 원소를 제외한 나머지를 왼쪽으로 이동
            rotated[length - 1] = numbers[0]; // 첫 번째 원소를 마지막 위치로 이동
        }

        return rotated;
    }
}