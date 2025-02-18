using System;

public class Solution 
{
    public int[] solution(int[] num_list) 
    {
        // num_list를 정렬합니다.
        Array.Sort(num_list);
        
        // 정렬된 배열에서 상위 5개를 가져옵니다. 
        // num_list의 크기가 5보다 작으면 그 크기만큼 반환합니다.
        int length = num_list.Length < 5 ? num_list.Length : 5;
        int[] answer = new int[length];
        
        // 상위 5개(혹은 num_list의 크기만큼) 요소를 answer 배열에 복사합니다.
        for (int i = 0; i < length; i++) 
        {
            answer[i] = num_list[i];
        }
        
        return answer;
    }
}
