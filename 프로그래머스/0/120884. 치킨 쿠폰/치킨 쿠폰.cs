using System;

public class Solution 
{
    public int solution(int chicken) 
    {
        int serviceChicken = 0;
        int coupons = chicken;

        while (coupons >= 10)
        {
            int newChicken = coupons / 10; // 서비스 치킨 개수
            serviceChicken += newChicken; 
            coupons = newChicken + (coupons % 10); // 남은 쿠폰 업데이트
        }

        return serviceChicken;
    }
}
