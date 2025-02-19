using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] num_list, int n) 
    {
        // n번째 이후의 원소 + n번째까지의 원소
        return num_list.Skip(n).Concat(num_list.Take(n)).ToArray();
    }
}
