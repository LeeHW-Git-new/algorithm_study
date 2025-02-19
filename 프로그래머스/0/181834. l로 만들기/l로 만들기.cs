using System;
using System.Linq;

public class Solution 
{
    public string solution(string myString) 
    {
        return new string(myString.Select(c => c < 'l' ? 'l' : c).ToArray());
    }
}
