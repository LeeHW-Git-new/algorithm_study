#include <string>
#include <vector>
#include <cmath>
#include <iostream>

using namespace std;

int solution(int n) 
{
    float answer;
    answer = n/7.0f;
    
    cout << answer;
    
    return (int)ceil(answer);
}