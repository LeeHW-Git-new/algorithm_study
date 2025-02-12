using System;

public class Solution 
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2) 
    {
        // 최소공배수(LCM) 계산
        int lcm = (denom1 * denom2) / GCD(denom1, denom2);

        // 분모를 LCM으로 맞춘 후 새로운 분자 계산
        int newNumer = (numer1 * (lcm / denom1)) + (numer2 * (lcm / denom2));
        int newDenom = lcm;

        // 최대공약수(GCD)를 이용하여 기약 분수로 변환
        int gcd = GCD(newNumer, newDenom);
        return new int[] { newNumer / gcd, newDenom / gcd };
    }

    // 최대공약수(GCD) 구하는 함수 (유클리드 호제법 사용)
    private int GCD(int a, int b) 
    {
        while (b != 0) 
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}