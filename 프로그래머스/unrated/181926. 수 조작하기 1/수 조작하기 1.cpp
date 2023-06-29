#include <string>
#include <vector>
#include <iostream>

using namespace std;

int solution(int n, string control) 
{
    int answer = n;
    
    for(int i = 0; i < control.size(); i++)
    {
        if(control[i] == 'w')
        {
            answer = answer+1;
        }
        else if(control[i] == 's')
        {
            answer = answer -1;
        }
        else if(control[i] == 'd')
        {
            answer = answer+10;
        }
        else if(control[i] == 'a')
        {
            answer = answer-10;
        }
    }
    
    
    return answer;
}