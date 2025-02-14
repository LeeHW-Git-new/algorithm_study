using System;

public class Example
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // 사용자 입력 받기

        for (int i = 1; i <= n; i++) // 1부터 n까지 반복
        {
            Console.WriteLine(new string('*', i)); // '*'을 i개 출력
        }
    }
}
