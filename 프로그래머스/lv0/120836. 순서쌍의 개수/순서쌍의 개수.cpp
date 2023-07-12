#include <string>
#include <vector>

using namespace std;

int solution(int n) 
{
    int answer = 1;
    int num = n;
    
    for(int i = 1; i < num; i++)
    {
        if(n % i == 0)
        {
            answer++;
        }
    }
    
    return answer;
}