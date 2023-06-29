#include <string>
#include <vector>
#include <iostream>

using namespace std;

vector<int> solution(vector<int> num_list) 
{
    vector<int> answer = num_list;
    
    int lastnum = num_list[num_list.size() - 1];
    int scenum = num_list[num_list.size() - 2];
    
    if(lastnum > scenum)
    {
        answer.push_back(lastnum - scenum);
    }
    else if(lastnum <= scenum)
    {
        answer.push_back(lastnum * 2);
    }
        

    
    return answer;
}