#include <string>
#include <vector>
#include <algorithm>
#include <iostream>

using namespace std;

int solution(vector<int> numbers) 
{

    int answer = 0;
    
    sort(numbers.begin(), numbers.end());
    reverse(numbers.begin(), numbers.end());
    
    answer = numbers[0] * numbers[1];
    
    return answer;
}