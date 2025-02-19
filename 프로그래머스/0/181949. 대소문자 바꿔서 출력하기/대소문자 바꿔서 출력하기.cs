using System;
using System.Linq;

class Solution 
{
    static void Main() 
    {
        string str = Console.ReadLine(); // 입력 받기
        string result = new string(str.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)).ToArray());
        Console.WriteLine(result); // 변환된 문자열 출력
    }
}
