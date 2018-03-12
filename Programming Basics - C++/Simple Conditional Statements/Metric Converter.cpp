#include <iostream>
#include <string>
#include <iomanip>
using namespace std;
 
int main()
{
    double input_value;
    double middle_value;
    double final_value;
    string input_metric, output_metric;
    cin >> input_value >> input_metric >> output_metric;
 
    if (input_metric == "mm")
    {
        middle_value = input_value / 1000;
    }
    else if (input_metric == "cm")
    {
        middle_value = input_value / 100;
    }
    else if (input_metric == "km")
    {
        middle_value = input_value / 0.001;
    }
    else if (input_metric == "mi")
    {
        middle_value = input_value / 0.000621371192;
    }
    else if (input_metric == "in")
    {
        middle_value = input_value / 39.3700787;
    }
    else if (input_metric == "ft")
    {
        middle_value = input_value / 3.2808399;
    }
    else if (input_metric == "yd")
    {
        middle_value = input_value / 1.0936133;
    }
    else if (input_metric == "m")
    {
        middle_value = input_value;
    }
 
    //Here in middle_value have the distance in meters.
   
    if (output_metric == "mm")
    {
        final_value = middle_value * 1000;
    }
    else if (output_metric == "cm")
    {
        final_value = middle_value * 100;
    }
    else if (output_metric == "km")
    {
        final_value = middle_value * 0.001;
    }
    else if (output_metric == "mi")
    {
        final_value = middle_value * 0.000621371192;
    }
    else if (output_metric == "in")
    {
        final_value = middle_value * 39.3700787;
    }
    else if (output_metric == "ft")
    {
        final_value = middle_value * 3.2808399;
    }
    else if (output_metric == "yd")
    {
        final_value = middle_value * 1.0936133;
    }
    else if (output_metric == "m")
    {
        final_value = middle_value;
    }
 
    cout << fixed << setprecision(8) << final_value << endl;
 
    return 0;
}