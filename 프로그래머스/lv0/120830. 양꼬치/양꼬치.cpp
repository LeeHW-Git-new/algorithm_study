#include <string>
#include <vector>

using namespace std;

int solution(int n, int k) 
{
    int answer = n * 12000;
    
    for(int i = 0; i < n+1; i++)
    {
        if(i % 10 == 0 && i!=0)
        {
            k--;
        }
    }
    answer += (k * 2000);

    return answer;
}