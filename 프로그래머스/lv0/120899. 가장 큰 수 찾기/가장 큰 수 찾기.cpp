#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> array) 
{
    vector<int> answer;
    int temp = array[0];
    int count = 0;
    
    for(int i = 0; i < array.size(); i++)
    {
        if(temp < array[i])
        {
            temp = array[i];
            count = i;
        }
    }
    answer.push_back(temp);
    answer.push_back(count);
    
    return answer;
}