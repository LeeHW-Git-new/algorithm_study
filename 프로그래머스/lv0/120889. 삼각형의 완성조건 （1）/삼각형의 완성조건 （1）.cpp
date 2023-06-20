#include <string>
#include <vector>
#include <algorithm>
#include <iostream>

using namespace std;

int solution(vector<int> sides) 
{
    sort(sides.begin(),sides.end());
    return (sides[2] < sides[0]+sides[1])?1:2;
}