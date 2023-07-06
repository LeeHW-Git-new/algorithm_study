#include <string>
#include <vector>

using namespace std;

string solution(string myString) 
{
    string answer = "";
    
    for(int i = 0; i < myString.size(); i++)
    {
        if(myString[i] == 'a' || myString[i] == 'A')
        {
            answer.push_back(toupper(myString[i]));
        }
        else
        {
            answer.push_back(tolower(myString[i]));
        }
    }
    
    return answer;
}