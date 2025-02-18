using System;

public class Solution 
{
    public string[] solution(string[] quiz) 
    {
        string[] answer = new string[quiz.Length];

        for (int i = 0; i < quiz.Length; i++)
        {
            // 수식을 공백 기준으로 분리
            string[] parts = quiz[i].Split(' ');

            // X, 연산자, Y, 결과 Z 추출
            int X = int.Parse(parts[0]);
            string operatorSign = parts[1];
            int Y = int.Parse(parts[2]);
            int Z = int.Parse(parts[4]);

            // 계산 결과와 Z 비교
            int result = 0;
            if (operatorSign == "+")
            {
                result = X + Y;
            }
            else if (operatorSign == "-")
            {
                result = X - Y;
            }

            // 결과가 맞으면 "O", 틀리면 "X"
            if (result == Z)
            {
                answer[i] = "O";
            }
            else
            {
                answer[i] = "X";
            }
        }

        return answer;
    }
}
