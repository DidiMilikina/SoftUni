#include<iostream>
#include<climits>
using namespace std;
 
 
int main()
{
    int number;
    double new_number;
    cin >> number;
    double odd_sum = 0;
    double even_sum = 0;
 
    double max_odd = INT_MIN;
    double min_odd = INT_MAX;
 
    double neutral_odd_max = INT_MIN;
    double neutral_odd_min = INT_MAX;
 
    double min_even = INT_MAX;
    double max_even = INT_MIN;
 
    double neutral_even_max = INT_MIN;
    double neutral_even_min = INT_MAX;
   
    for (int i = 1; i <= number; i++)
    {
        cin >> new_number;
        if (i % 2 == 1)
        {
            odd_sum += new_number;
            if (max_odd < new_number)
            {
                max_odd = new_number;
            }
            if (min_odd > new_number)
            {
                min_odd = new_number;
            }
 
        }
        else
        {
            even_sum += new_number;
            if (max_even < new_number)
            {
                max_even = new_number;
            }
            if (min_even > new_number)
            {
                min_even = new_number;
            }
        }
    }
   
    cout <<"OddSum="<< odd_sum<<", ";
    if (max_odd == neutral_odd_max && min_odd == neutral_odd_min)
    {
        cout << "OddMin=No" << ", ";
        cout << "OddMax=No" << ", ";
    }
    else if (max_odd== neutral_odd_max)
    {
        cout << "OddMin=" << min_odd << ", ";
        cout << "OddMax=No" << ", ";
    }
    else if (min_odd == neutral_odd_min)
    {
        cout << "OddMin=No" << min_odd << ", ";
        cout << "OddMax=" <<max_odd << ", ";
    }
    else if (max_odd != neutral_odd_max && min_odd != neutral_odd_min)
    {
        cout << "OddMin="<<min_odd << ", ";
        cout << "OddMax="<<max_odd << ", ";
    }
   
 
 
    cout <<"EvenSum="<< even_sum<<", ";
    if (max_even == neutral_even_max && min_even == neutral_even_min)
    {
        cout << "EvenMin=No" << ", ";
        cout << "EvenMax=No";
    }
    else if (max_even == neutral_even_max)
    {
        cout << "EvenMin=" << min_even << ", ";
        cout << "EvenMax=No";
    }
    else if (min_even == neutral_even_min)
    {
        cout << "EvenMin=No" << min_even << ", ";
        cout << "EvenMax=" << max_even;
    }
    else if (max_even != neutral_even_max && min_even != neutral_even_min)
    {
        cout << "EvenMin=" << min_even << ", ";
        cout << "EvenMax=" << max_even;
    }
 
    return 0;
}