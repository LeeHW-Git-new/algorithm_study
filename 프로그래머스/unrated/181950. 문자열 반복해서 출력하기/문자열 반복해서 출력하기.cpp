#include <iostream>
#include <string>

using namespace std;

int main(void) 
{
    string str;
    int n;
    string temp;
    
    cin >> str >> n;
    temp = str;
    
    for(int i = 0 ; i < n-1; i++)
    {
        str += temp;
    }
    
    cout << str;
    
    return 0;
}