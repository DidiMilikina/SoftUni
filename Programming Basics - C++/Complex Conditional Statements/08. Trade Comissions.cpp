#include <iostream>
#include <iomanip>
#include <string>
#include <cmath>
 
using namespace std;
 
int main()
{
    string town;
    double sales, comm;
 
    cin >> town >> sales;
 
    comm = 0;
 
    if (town == "Sofia") {
        if (sales >= 0 && sales <= 500) {
            comm = sales * 5 / 100.00;
        }
        else if (sales > 500 && sales <= 1000) {
            comm = sales * 7 / 100.00;
        }
        else if (sales > 1000 && sales <= 10000) {
            comm = sales * 8 / 100.00;
        }
        else if (sales > 10000) {
            comm = sales * 12 / 100.00;
        }
    }
    else if (town == "Varna") {
       
        if (sales >= 0 && sales <= 500) {
            comm = sales * 4.5 / 100.00;
        }
        else if (sales > 500 && sales <= 1000) {
            comm = sales * 7.5 / 100.00;
        }
        else if (sales > 1000 && sales <= 10000) {
            comm = sales * 10 / 100.00;
        }
        else if (sales > 10000) {
            comm = sales * 13 / 100.00;
        }
    }
    else if (town == "Plovdiv") {
       
        if (sales >= 0 && sales <= 500) {
            comm = sales * 5.5 / 100.00;
        }
        else if (sales > 500 && sales <= 1000) {
            comm = sales * 8 / 100.00;
        }
        else if (sales > 1000 && sales <= 10000) {
            comm = sales * 12 / 100.00;
        }
        else if (sales > 10000) {
            comm = sales * 14.5 / 100.00;
        }
    }
 
    if (comm <= 0) {
        cout << "error" << endl;
    }
 
    else {
        cout << fixed << setprecision(2) << comm << endl;
    }
    return 0;
}