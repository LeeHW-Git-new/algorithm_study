#include <string>
#include <vector>

using namespace std;

int gcd(int a , int b)
{
    if(b == 0) return a;
    else return gcd(b, a%b);
}

int solution(int n) 
{
    int answer;
    answer = gcd(6,n);
    
    return n / answer;
}

