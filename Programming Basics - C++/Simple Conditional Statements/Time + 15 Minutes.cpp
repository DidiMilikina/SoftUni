#include <iostream>
using namespace std;
 
int main()
{
    int hours, minutes;
    cin >> hours >> minutes;
 
    minutes += 15;
    if (minutes >= 60)
    {
        hours++;
        minutes -= 60;
    }
    if (hours >= 24)
    {
        hours -= 24;
    }
    cout << hours << ":";
    if (minutes < 10)
    {
        cout << "0";
    }
    cout << minutes << endl;
 
    return 0;
}