#include <string>
#include <vector>

using namespace std;

string solution(string my_string, int n) 
{
    string answer = "";
    int size = my_string.size();
    
    for(int i = size - n; i < size; i++)
    {
       answer += my_string[i];
    }
    return answer;
}