using System;

public class Solution 
{
    public int solution(int a, int b) 
    {
        // 최대공약수 구하기
        int gcd = GCD(a, b);
        
        // 기약분수의 분모 계산
        int denominator = b / gcd;

        // 분모의 소인수가 2와 5만 있는지 확인
        while (denominator % 2 == 0) 
        {
            denominator /= 2;
        }
        while (denominator % 5 == 0) 
        {
            denominator /= 5;
        }
        
        // 분모가 1이면 유한소수 (1 반환), 그렇지 않으면 무한소수 (2 반환)
        return denominator == 1 ? 1 : 2;
    }

    // 최대공약수(GCD) 구하는 함수 (유클리드 호제법)
    private int GCD(int x, int y) 
    {
        while (y != 0) 
        {
            int temp = y;
            y = x % y;
            x = temp;
        }
        return x;
    }
}
