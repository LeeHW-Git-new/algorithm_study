using System;
using System.Linq;

public class Solution 
{
    public string solution(string my_string) 
    {
       return new string(my_string.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
    }
}