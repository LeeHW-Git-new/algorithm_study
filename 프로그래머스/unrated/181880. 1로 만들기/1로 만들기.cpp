#include <string>
#include <vector>
#include <iostream>
using namespace std;

int solution(vector<int> num_list) 
{
    int answer = 0;
    int temp = 0;
    for(int i = 0; i < num_list.size(); i++)
    {
        temp = num_list[i];
        
        while(temp != 1)
        {
            if(temp % 2 == 0)
            {
                temp = temp / 2;
            }
            else if(temp % 2 == 1)
            {
                temp = (temp - 1) / 2;
            }
            answer++;
        }
    }
    
    return answer;
}