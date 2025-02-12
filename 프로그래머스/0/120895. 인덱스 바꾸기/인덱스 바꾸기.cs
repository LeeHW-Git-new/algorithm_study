using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) 
    {
        string answer = "";
        char[] copy = my_string.ToCharArray();
        char temp = copy[num1];
        copy[num1] = copy[num2];
        copy[num2] = temp;
        answer = string.Concat(copy);
        
        return answer;
    }
}