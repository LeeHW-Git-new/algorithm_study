using System;
using System.Linq;

public class Solution 
{
    public string solution(string my_string) 
    {
        return string.Concat(my_string.ToLower().OrderBy(c => c));
    }
}