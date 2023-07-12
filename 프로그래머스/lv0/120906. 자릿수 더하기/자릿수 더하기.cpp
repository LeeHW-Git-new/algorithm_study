#include <string>
#include <vector>
#include <iostream>

using namespace std;

int solution(int n) 
{
    int answer = 0;
    string str = to_string(n);
    
    for(int i = 0; i < str.size(); i++)
    {
        char temp = str[i];
        int num = stoi(&temp);
        
        answer += num;
    }
    
    return answer;
}