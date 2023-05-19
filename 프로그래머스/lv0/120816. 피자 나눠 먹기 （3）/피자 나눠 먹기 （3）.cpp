#include <string>
#include <vector>
#include <cmath>

using namespace std;

int solution(int slice, int n) 
{
    int answer = 0;
    
    float m = 0.f;
    m = (float)n / (float)slice;
    
    answer = ceil(m);
    
    return answer;
}