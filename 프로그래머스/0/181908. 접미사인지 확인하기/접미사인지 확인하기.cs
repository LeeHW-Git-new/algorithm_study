using System;

public class Solution 
{
    public int solution(string my_string, string is_suffix) 
    {
        return my_string.EndsWith(is_suffix) ? 1 : 0;
    }
}
