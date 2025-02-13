using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(int[] array) 
    {
                Dictionary<int, int> freqMap = new Dictionary<int, int>();

        // 각 숫자의 등장 횟수 기록
        foreach (int num in array) 
        {
            if (freqMap.ContainsKey(num))
                freqMap[num]++;
            else
                freqMap[num] = 1;
        }

        int maxFreq = freqMap.Values.Max(); // 최빈값의 빈도
        var modes = freqMap.Where(x => x.Value == maxFreq).Select(x => x.Key).ToList();

        return modes.Count > 1 ? -1 : modes[0];
    }
}
