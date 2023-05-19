#include <string>
#include <vector>

using namespace std;

vector<int> solution(int money) 
{
    vector<int> answer;
    int resultAA , resultMoney;
    
    resultAA = money / 5500;
    resultMoney = money % 5500;
    
    answer.push_back(resultAA);
    answer.push_back(resultMoney);
    
    return answer;
}