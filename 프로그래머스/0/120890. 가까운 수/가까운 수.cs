using System;
using System.Linq;

public class Solution 
{
    public int solution(int[] array, int n) 
    {
        // 오름차순 정렬 (차이가 같을 경우 작은 값을 반환하기 위함)
        array = array.OrderBy(x => x).ToArray();

        // LINQ를 이용하여 차이가 가장 작은 값 찾기
        return array.OrderBy(x => Math.Abs(x - n)).First();
    }
}
