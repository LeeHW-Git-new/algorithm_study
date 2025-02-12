using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string my_string) 
    {
            return my_string.Where(char.IsDigit)
                       .Select(c => int.Parse(c.ToString()))
                       .OrderBy(n => n)
                       .ToArray();
    }
}