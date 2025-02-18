using System;

public class Solution 
{
    public string solution(string polynomial) 
    {
        int xCoeff = 0;  // x의 계수
        int constant = 0; // 상수항

        // 다항식을 공백으로 나눔
        string[] terms = polynomial.Split(" ");

        foreach (string term in terms)
        {
            if (term.Contains("x"))
            {
                // 'x'가 포함된 항 처리
                string coeff = term.Replace("x", "").Trim();  // x 앞의 계수 추출

                // 계수가 없으면 1로 간주
                if (coeff == "" || coeff == "+")
                {
                    xCoeff += 1;
                }
                // 계수가 -일 경우
                else if (coeff == "-")
                {
                    xCoeff -= 1;
                }
                // 숫자가 있으면 해당 숫자만큼 계수를 더함
                else
                {
                    xCoeff += int.Parse(coeff);
                }
            }
            else if (term != "+")
            {
                // 상수항 처리
                constant += int.Parse(term);
            }
        }

        // 결과 포맷 생성
        string result = "";

        // x 항이 있을 경우
        if (xCoeff != 0)
        {
            if (xCoeff == 1)
            {
                result += "x";
            }
            else if (xCoeff == -1)
            {
                result += "-x";
            }
            else
            {
                result += xCoeff + "x";
            }
        }

        // 상수항이 있을 경우
        if (constant != 0)
        {
            if (result != "")
            {
                result += " + " + constant;
            }
            else
            {
                result += constant;
            }
        }

        return result;
    }
}
