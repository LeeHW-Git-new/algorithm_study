#include <string>
#include <vector>

using namespace std;

int solution(vector<int> num_list) 
{
    int answer = 0;
    int aa;
    int bb;
    
    
    for(int i = 0 ; i < num_list.size(); i++)
    {
        if((i + 1) % 2 == 0)
        {
            aa += num_list[i];
        }
        else if((i + 1) % 2 == 1)
        {
            bb += num_list[i];
        }
    }
    
    if(aa >= bb)
    {
        answer = aa;
    }
    else if(bb >= aa)
    {
        answer = bb;
    }
    
    
    return answer;
}