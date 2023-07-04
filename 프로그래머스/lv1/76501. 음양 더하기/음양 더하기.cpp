#include <string>
#include <vector>
#include <iostream>

using namespace std;

int solution(vector<int> absolutes, vector<bool> signs) 
{
    int answer = 0;
    vector<int> arr;
    
    for(int i = 0; i < signs.size(); i++)
    {
        if(signs[i] == 0)
        {
            arr.push_back(-1 * absolutes[i]);
            
        }
        else
        {
            arr.push_back(absolutes[i]);
        }
    }
    
    for(int i = 0; i < arr.size(); i++)
    {
        answer += arr[i];
    }
    
    return answer;
}