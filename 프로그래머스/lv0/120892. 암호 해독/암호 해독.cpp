#include <string>
#include <vector>

using namespace std;

string solution(string cipher, int code) 
{
    string answer = "";
    
    for(int i = 0; i < cipher.size()+1; i++)
    {
        if(i!= 0 && i % code == 0)
        {
            answer.push_back(cipher[i-1]);
        }
    }
    
    return answer;
}