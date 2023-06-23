#include <string>
#include <vector>
#include <iostream>

using namespace std;

int solution(vector<int> num_list) 
{
    int answer = 0;
    
    if(num_list.size()  >= 11)
    {
        for(int i = 0 ; i < num_list.size(); i++)
        {
            answer += num_list[i];
        }
    }
    else
    {
        answer = 1;
        for(int i = 0; i < num_list.size(); i++)
        {
            answer *= num_list[i];
            
            cout << answer << endl;
        }
    }
    
    return answer;
}