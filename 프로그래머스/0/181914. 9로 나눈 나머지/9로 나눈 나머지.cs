using System;
using System.Linq;

public class Solution 
{
    public int solution(string number) 
    {
        return number.Sum(c => c - '0') % 9;
    }
}