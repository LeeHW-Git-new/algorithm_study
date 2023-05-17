#include <string>
#include <vector>
#include <cmath>
#include <iostream>

using namespace std;

int solution(vector<int> num_list) 
{
    int sum = 0;
    int mul = 1;
    
    for(int i = 0; i < num_list.size(); i++)
    {
        sum += num_list[i];
        mul *= num_list[i];
        
        cout << sum <<endl;
        cout << mul <<endl;
    }
    
    int sums = pow(sum , 2);
    
    if(mul < sums)
        return 1;
    else if(mul > sums)
        return 0;
}